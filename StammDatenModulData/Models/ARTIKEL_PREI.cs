using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ARTIKEL_PREI
{
    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string FILIALLE_NR { get; set; } = null!;

    public string? ARTIKEL_NR { get; set; }

    public string? ARTIKEL_NAME { get; set; }

    public string? MWST { get; set; }

    public float PREIS { get; set; }

    public float? EK_PREIS { get; set; }

    public string? HERSTELLER { get; set; }

    public string? BENUTZER_NR { get; set; }

    public string? WARENGRUPPE { get; set; }

    public string? LIEFERANTEN { get; set; }

    public string? PACKUNGSINHALT { get; set; }

    public int? SENDEN { get; set; }
}
