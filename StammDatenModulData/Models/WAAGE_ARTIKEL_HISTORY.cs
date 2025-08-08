using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class WAAGE_ARTIKEL_HISTORY
{
    public int FILIALLE_NR { get; set; }

    public int ABTEILUNG_NR { get; set; }

    public int WG_NR { get; set; }

    public string ARTIKEL_NR { get; set; } = null!;

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string ARTIKEL_NAME { get; set; } = null!;

    public int MWST { get; set; }

    public float EK_PREIS { get; set; }

    public float VK_PREIS { get; set; }

    public string? WAAGE_HERSTELLER { get; set; }

    public string? WIEGE_ARTIKEL { get; set; }

    public byte[]? BILD { get; set; }

    public string? ETIKET_DRUCKEN { get; set; }

    public float? GEWINN { get; set; }

    public string? BARCODE_NR { get; set; }

    public int? BENUTZER_NR { get; set; }

    public int? SENDEN { get; set; }
}
