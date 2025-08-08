using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class SCHUBLADE_INFO
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT_OFFNEN { get; set; }

    public TimeSpan ZEIT_SCHLIESSEN { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public string? QUITTUNGSNUMMER { get; set; }

    public string? TSE_TRANSACTION_NR { get; set; }

    public int? TOTAL_ZEIT { get; set; }

    public int? BENUTZER_NR { get; set; }

    public string? SENDEN { get; set; }
}
