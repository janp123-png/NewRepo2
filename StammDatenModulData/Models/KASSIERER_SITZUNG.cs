using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class KASSIERER_SITZUNG
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public int KASSIERER_NR { get; set; }

    public int SITZSUNG_NR { get; set; }

    public DateTime? DATUM { get; set; }

    public TimeSpan? VON { get; set; }

    public TimeSpan? BIS { get; set; }

    public float? ANFANG_BESTAND { get; set; }

    public float? END_BESTAND { get; set; }

    public float? TOTAL_UMSATZ { get; set; }

    public short? STATUS { get; set; }

    public string? BENUTZER_NAME { get; set; }

    public int? SENDEN { get; set; }
}
