using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class TRANSACTIONS_TSE
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string BON_ID { get; set; } = null!;

    public string TSE_ID { get; set; } = null!;

    public string? TSE_TANR { get; set; }

    public string? TSE_TA_START { get; set; }

    public string? TSE_TA_ENDE { get; set; }

    public string? TSE_TA_VORGANGSART { get; set; }

    public string? TSE_TA_SIGZ { get; set; }

    public string? TSE_TA_SIG { get; set; }

    public string? TSE_TA_FEHLER { get; set; }

    public string? TSE_VORGANGSDATEN { get; set; }
}
