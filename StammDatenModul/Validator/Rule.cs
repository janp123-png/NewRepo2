using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StammDatenModul.Validator
{
    public sealed class Rule
    {
        public string Name { get; set; } = "";
        public string Expression { get; set; } = "";
        public string ErrorMessage { get; set; } = "";
        public string Severity { get; set; } = "Error"; // z. B. "Error", "Warning", "Info"
    }

}
