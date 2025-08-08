using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class TSE
{
    public int FILIALLE_NR { get; set; }

    public string KASSE_ID { get; set; } = null!;

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public long TRANSACTION_NR { get; set; }

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public long QUITTUNGSNUMMER { get; set; }

    public string? SIGNATURE_COUNTER { get; set; }

    public string? TSE_SERIAL_NUMMER { get; set; }

    public string? TRANSACTION_START_TIME { get; set; }

    public string? TRANSACTION_FINISH_TIME { get; set; }

    public string? TSE_SIGNATURE_DATEN { get; set; }

    public string? TSE_PUBLICKEY { get; set; }

    public string? TSE_BONN_DATEN { get; set; }

    public string? TSE_ZEIT_FORMAT { get; set; }

    public string? TSE_SIGNATUR_ALG { get; set; }

    public string? TSE_DATEN { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public string? TSE_ID { get; set; }

    public string? TSE_TA_FEHLER { get; set; }

    public int? SENDEN { get; set; }

    public long? BON_ID { get; set; }
}
