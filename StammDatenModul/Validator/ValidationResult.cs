using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StammDatenModul.Validator;

namespace StammDatenModul
{
    public sealed class ValidationResult
    {
        public List<RuleResult> Results { get; } = new();

        /// <summary>
        /// Gültig, wenn alle Regeln entweder bestanden sind oder nur "Info"/"Warning" geliefert haben.
        /// </summary>
        public bool IsValid =>
            Results.All(r =>
                r.Passed ||
                r.Severity.Equals("Info", StringComparison.OrdinalIgnoreCase) ||
                r.Severity.Equals("Warning", StringComparison.OrdinalIgnoreCase));
    }

}
