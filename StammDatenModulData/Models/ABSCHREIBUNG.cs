using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ABSCHREIBUNG
{
    public short FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int ABSCHREIBUNG_NR { get; set; }

    public int POS { get; set; }

    public DateTime DATUM { get; set; }

    public string? BENUTZER_NR { get; set; }

    public string? ARTIKEL_NR { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public float? MWST { get; set; }

    public float? MENGE { get; set; }

    public string? EINHEIT { get; set; }

    public float? EK_PREIS { get; set; }

    public float? TOTAL_ABSCHREIBUNG { get; set; }

    public string? ABTEILUNG { get; set; }
}
