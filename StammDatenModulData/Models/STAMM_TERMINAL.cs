using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class STAMM_TERMINAL
{
    public int FILIALLE_NR { get; set; }

    public string TERMINAL_ID { get; set; } = null!;

    public int? KASSE_NR { get; set; }

    public string? KASSE_ID { get; set; }

    public string? TERMINAL_BRAND { get; set; }

    public string? TERMINAL_MODELL { get; set; }

    public string? TERMINAL_SERIENNR { get; set; }

    public string? TERMINAL_SW_BRAND { get; set; }

    public string? TERMINAL_SW_VERSION { get; set; }

    public DateTime? GULTIG_VON { get; set; }

    public DateTime? GULTIG_BIS { get; set; }

    public string? TSE_AKTIV { get; set; }
}
