using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class VIEW_ARTIKEL_GEWINN
{
    public int? FILIALLE_NR { get; set; }

    public int? KASSE_NR { get; set; }

    public DateTime? DATUM { get; set; }

    public string? ARTIKEL_NR { get; set; }

    public string? VERKAUF_ART { get; set; }

    public double? GEWINN { get; set; }
}
