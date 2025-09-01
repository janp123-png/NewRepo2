using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StammDatenModul.Validator
{
    public sealed class RuleResult
    {
        public string RuleName { get; init; } = "";
        public bool Passed { get; init; }
        public string Severity { get; init; } = "Error";
        public string Message { get; init; } = "";
        public Exception? Exception { get; init; }
    }

}
