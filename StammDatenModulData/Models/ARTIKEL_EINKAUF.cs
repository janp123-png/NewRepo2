using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ARTIKEL_EINKAUF
{
    public string FILIALLE_NR { get; set; } = null!;

    public string LIEFERANTEN_NAME { get; set; } = null!;

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string ARTIKEL_NR { get; set; } = null!;

    public int POS { get; set; }

    public string? ARTIKEL_LIEF_NR { get; set; }

    public string? ARTIKEL_NAME { get; set; }

    public string? WARENGRUPPE { get; set; }

    public float? MWST { get; set; }

    public float? PFAND { get; set; }

    public float? GEWICHT { get; set; }

    public float? PACKUNGSINHALT { get; set; }

    public float? PACKUNGSMENGE { get; set; }

    public float? MENGE { get; set; }

    public string? EINHEIT { get; set; }

    public float? EK_PREIS { get; set; }

    public float? TOTAL_EK { get; set; }

    public float? VK_PREIS { get; set; }

    public float? GEWINN_PROZENT { get; set; }

    public float? GEWINN_BETRAG { get; set; }

    public string? BENUTZER_NR { get; set; }

    public string? BELEG_NR { get; set; }

    public string? WE_DATUM { get; set; }

    public string? ARTIKEL_SN_NUMMER { get; set; }

    public int? SENDEN { get; set; }
}
