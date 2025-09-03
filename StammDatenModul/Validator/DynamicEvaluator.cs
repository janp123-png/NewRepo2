using System;
using System.Reflection;
using StammDatenModul.Validator;

public static class DynamicEvaluator
{
    public static bool Evaluate(object entity, string expression)
    {
        // Teile den Ausdruck in OR-Gruppen (||)
        var orGroups = expression.Split(new[] { "||" }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var group in orGroups)
        {
            // Jede Gruppe wird mit AND geprüft
            var andParts = group.Split(new[] { "&&" }, StringSplitOptions.RemoveEmptyEntries);
            bool groupResult = true;

            foreach (var part in andParts)
            {
                string trimmed = part.Trim();
                bool negate = false;

                if (trimmed.StartsWith("!"))
                {
                    negate = true;
                    trimmed = trimmed.Substring(1).Trim();
                }

                bool result = EvaluatePart(entity, trimmed);

                if (negate) result = !result;

                if (!result)
                {
                    groupResult = false;
                    break; // eine Bedingung in dieser Gruppe ist false
                }
            }

            if (groupResult)
                return true; // eine OR-Gruppe erfüllt → Gesamt true
        }

        return false; // keine Gruppe erfüllt
    }

    private static bool EvaluatePart(object entity, string part)
    {
        part = part.Trim();
        bool result = false;

        try
        {
            // AllDigits Funktion
            if (part.StartsWith("AllDigits(") && part.EndsWith(")"))
            {
                var propName = part.Substring(10, part.Length - 11).Trim();
                var prop = GetPropertyCaseInsensitive(entity, propName);
                var value = prop?.GetValue(entity) as string;
                result = DynamicHelpers.AllDigits(value);
            }
            // IsNullOrWhiteSpace Funktion
            else if (part.StartsWith("IsNullOrWhiteSpace(") && part.EndsWith(")"))
            {
                var inner = part.Substring("IsNullOrWhiteSpace(".Length,
                                           part.Length - "IsNullOrWhiteSpace(".Length - 1);
                var propName = inner.Trim();

                var prop = GetPropertyCaseInsensitive(entity, propName);
                var value = prop?.GetValue(entity) as string;
                result = string.IsNullOrWhiteSpace(value);
            }
            // Length == X
            else if (part.Contains(".Length"))
            {
                var tokens = part.Split(new[] { ".Length" }, StringSplitOptions.None);
                var propName = tokens[0].Trim();
                var prop = GetPropertyCaseInsensitive(entity, propName);
                var value = prop?.GetValue(entity) as string;

                if (value == null) return false;

                if (part.Contains("=="))
                {
                    int expected = int.Parse(part.Split(new[] { "==" }, StringSplitOptions.None)[1].Trim());
                    result = value.Length == expected;
                }
                else if (part.Contains("!="))
                {
                    int expected = int.Parse(part.Split(new[] { "!=" }, StringSplitOptions.None)[1].Trim());
                    result = value.Length != expected;
                }
                else
                {
                    throw new Exception("Operator für .Length nicht unterstützt: " + part);
                }
            }
            // Operatoren: ==, !=, >=, <=, >, <
            else
            {
                string[] operators = new[] { ">=", "<=", "==", "!=", ">", "<" };
                foreach (var op in operators)
                {
                    if (part.Contains(op))
                    {
                        var tokens = part.Split(new[] { op }, StringSplitOptions.None);
                        var propName = tokens[0].Trim();
                        var valueStr = tokens[1].Trim().Trim('"');

                        var prop = GetPropertyCaseInsensitive(entity, propName);
                        var propValue = prop?.GetValue(entity);

                        if (propValue == null)
                        {
                            result = false;
                        }
                        else if (double.TryParse(propValue.ToString(), out double propNum) &&
                                 double.TryParse(valueStr, out double valueNum))
                        {
                            result = op switch
                            {
                                ">" => propNum > valueNum,
                                ">=" => propNum >= valueNum,
                                "<" => propNum < valueNum,
                                "<=" => propNum <= valueNum,
                                "==" => propNum == valueNum,
                                "!=" => propNum != valueNum,
                                _ => false
                            };
                        }
                        else
                        {
                            result = op switch
                            {
                                "==" => propValue.ToString() == valueStr,
                                "!=" => propValue.ToString() != valueStr,
                                _ => throw new Exception("Operator für String nicht unterstützt: " + op)
                            };
                        }

                        break;
                    }
                }
            }
        }
        catch
        {
            result = false; // Falls irgendwas schief geht → false
        }

        return result;
    }
    private static PropertyInfo GetPropertyCaseInsensitive(object entity, string propName)
    {
        var type = entity.GetType();
        var prop = type.GetProperty(propName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase);
        if (prop == null)
            throw new Exception($"Property '{propName}' nicht gefunden auf Typ {type.Name}");
        return prop;
    }
    
    private static bool AllDigits(string? input) =>
          !string.IsNullOrEmpty(input) && input.All(char.IsDigit);

    private static bool IsNullOrWhiteSpace(string? input) =>
        string.IsNullOrWhiteSpace(input);
    private static readonly Dictionary<string, Delegate> _functions = new()
    {
        { "AllDigits", new Func<string, bool>(AllDigits) },
        { "IsNullOrWhiteSpace", new Func<string, bool>(IsNullOrWhiteSpace) }
    };

}
