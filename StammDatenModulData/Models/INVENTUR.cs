using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class INVENTUR
{
    public short FILIALLE_NR { get; set; }

    public int INVENTUR_NR { get; set; }

    public DateTime DATUM { get; set; }

    public string ARTIKEL_NR { get; set; } = null!;

    public string? ARTIKEL_NAME { get; set; }

    public string? WARENGRUPPE { get; set; }

    public string? LIEFERANTEN { get; set; }

    public string? EINHEIT { get; set; }

    public float? MWST { get; set; }

    public float? BESTAND { get; set; }

    public float? NETTO_EK { get; set; }

    public float? TOTAL_EK { get; set; }

    public float? BRUTTO_VK { get; set; }

    public float? TOTAL_VK { get; set; }
}
