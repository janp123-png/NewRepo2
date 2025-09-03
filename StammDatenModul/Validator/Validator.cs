using System;
using System.Collections.Generic;
using System.Text.Json;
using StammDatenModul.Validator;

public class GenericValidator
{
    private readonly Dictionary<string, List<Rule>> _rules;

    public GenericValidator(Dictionary<string, List<Rule>> rules)
    {

        _rules = rules;
    }

    public List<string> Validate(object entity)
    {
        var errors = new List<string>();

        // Typname des Objekts bestimmen (z. B. ARTIKEL, KUNDE)
        string typeName = entity.GetType().Name.ToUpper();

        if (!_rules.ContainsKey(typeName)) return errors;

        foreach (var rule in _rules[typeName])
        {
            if (!DynamicEvaluator.Evaluate(entity, rule.Expression))
                errors.Add(rule.ErrorMessage);
        }

        return errors;
    }
}
