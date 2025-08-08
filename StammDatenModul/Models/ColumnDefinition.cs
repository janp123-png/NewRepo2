using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StammDatenModul.Models;
public class ColumnDefinitionDatabase
{
    public string Name { get; set; }
    public Type DataType { get; set; }
    public bool IsNullable { get; set; }
}
