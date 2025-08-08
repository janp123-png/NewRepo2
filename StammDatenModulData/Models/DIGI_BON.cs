using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class DIGI_BON
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int WAAGE_NR { get; set; }

    public int TRANSACTION_NR { get; set; }

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string? BEDIENER { get; set; }

    public string? BONTYPE { get; set; }

    public float? BON_TOTAL { get; set; }

    public string? SENDEN { get; set; }

    public int? VERKAUFT { get; set; }
}
