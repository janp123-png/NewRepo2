using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class BARGELD
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public string KASSE_ID { get; set; } = null!;

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public int POS { get; set; }

    public string GESCHAFTSVORFALL { get; set; } = null!;

    public string? BEZEICHNUNG { get; set; }

    public int TSE_TRNR { get; set; }

    public float? EINNAHME { get; set; }

    public float? AUSGABE { get; set; }

    public int? SITZUNG_NR { get; set; }

    public int? BENUTZER_NR { get; set; }

    public int? SENDEN { get; set; }

    public long? BON_ID { get; set; }
}
