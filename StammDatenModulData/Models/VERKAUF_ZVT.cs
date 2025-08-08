using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class VERKAUF_ZVT
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public int SITZUNG_NR { get; set; }

    public long QUITTUNGSNUMMER { get; set; }

    public long TSE_TRANSACTION_NR { get; set; }

    public string KASSE_ID { get; set; } = null!;

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string? KUNDENBELEG { get; set; }

    public string? HANDLERBELEG { get; set; }

    public string? KARTEN_TYPE { get; set; }

    public long? BON_ID { get; set; }

    public int? SENDEN { get; set; }
}
