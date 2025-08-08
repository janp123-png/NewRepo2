using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class VIEW_ARTIKEL_VERKAUF_HISTORY
{
    public int? FILIALLE_NR { get; set; }

    public string? ARTIKEL_NR { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public DateTime? DATUM { get; set; }

    public string? WARENGRUPPE { get; set; }

    public float? VK_PREIS { get; set; }

    public double? MENGE { get; set; }

    public string? EINHEIT { get; set; }

    public double? UMSATZ { get; set; }
}
