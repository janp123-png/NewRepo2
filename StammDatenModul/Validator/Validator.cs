using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using StammDatenModul.Config;

namespace StammDatenModul.Validator
{
    public sealed class ScriptGlobals
    {
        public object Entity { get; }
        public DateTime Now { get; }

        public ScriptGlobals(object entity)
        {
            Entity = entity;
            Now = DateTime.UtcNow;
        }
    }

    public sealed class DynamicValidator
    {
        private readonly ScriptOptions _options;
        private readonly TimeSpan _perRuleTimeout;

        // Primitive „Guards“ gegen gefährliche APIs
        private readonly string[] _blockedTokens =
        {
        "System.IO", "System.Net", "System.Reflection", "System.Diagnostics",
        "System.Runtime.InteropServices", "DllImport", "Environment", "Process",
        "File", "Directory", "Console.OpenStandard", "Activator", "AppDomain"
    };

        public DynamicValidator(TimeSpan perRuleTimeout)
        {
            _perRuleTimeout = perRuleTimeout;

            var safeReferences = new[]
            {
            typeof(object).Assembly,
            typeof(Enumerable).Assembly,
            typeof(Math).Assembly
        };

            _options = ScriptOptions.Default
                .WithReferences(safeReferences)
                .WithImports("System", "System.Linq", "System.Collections.Generic", "System.Math")
                .WithEmitDebugInformation(false);
        }

        /// <summary>
        /// Lädt Regeln für mehrere Tabellen aus JSON.
        /// </summary>
        public static IReadOnlyDictionary<string, List<Rule>> LoadRulesFromJson(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Rules-JSON nicht gefunden: {path}");

            var json = File.ReadAllText(path);

            var rules = JsonSerializer.Deserialize<Dictionary<string, List<Rule>>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                ?? new Dictionary<string, List<Rule>>();

            return rules;
        }

        /// <summary>
        /// Validiert ein beliebiges Objekt (Entity) gegen die Regeln einer Tabelle.
        /// </summary>
        public async Task<ValidationResult> ValidateAsync(object entity, string tableName, IReadOnlyDictionary<string, List<Rule>> allRules)
        {
            var result = new ValidationResult();

            if (!allRules.TryGetValue(tableName, out var rules) || rules.Count == 0)
                return result; // Keine Regeln = automatisch gültig

            var globals = new ScriptGlobals(entity);

            foreach (var rule in rules)
            {
                if (ContainsBlockedTokens(rule.Expression))
                {
                    result.Results.Add(new RuleResult
                    {
                        RuleName = rule.Name,
                        Passed = false,
                        Severity = rule.Severity,
                        Message = "Regel enthält blockierte Tokens."
                    });
                    continue;
                }

                using var cts = new CancellationTokenSource(_perRuleTimeout);

                try
                {
                    var ok = await CSharpScript.EvaluateAsync<bool>(
                        code: rule.Expression,
                        options: _options,
                        globals: globals,
                        globalsType: typeof(ScriptGlobals),
                        cancellationToken: cts.Token
                    ).ConfigureAwait(false);

                    result.Results.Add(new RuleResult
                    {
                        RuleName = rule.Name,
                        Passed = ok,
                        Severity = rule.Severity,
                        Message = ok ? "OK" : rule.ErrorMessage
                    });
                }
                catch (OperationCanceledException)
                {
                    result.Results.Add(new RuleResult
                    {
                        RuleName = rule.Name,
                        Passed = false,
                        Severity = rule.Severity,
                        Message = "Regelprüfung abgebrochen (Timeout)."
                    });
                }
                catch (CompilationErrorException cee)
                {
                    result.Results.Add(new RuleResult
                    {
                        RuleName = rule.Name,
                        Passed = false,
                        Severity = rule.Severity,
                        Message = "Regel konnte nicht kompiliert werden.",
                        Exception = cee
                    });
                }
                catch (Exception ex)
                {
                    result.Results.Add(new RuleResult
                    {
                        RuleName = rule.Name,
                        Passed = false,
                        Severity = rule.Severity,
                        Message = "Fehler bei der Regelauswertung.",
                        Exception = ex
                    });
                }
            }

            return result;
        }

        private bool ContainsBlockedTokens(string expression)
        {
            var expr = expression ?? string.Empty;
            return _blockedTokens.Any(token =>
                expr.IndexOf(token, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }

}
