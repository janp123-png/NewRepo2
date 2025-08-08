using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class SLAfe
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string? TERMINAL_ID { get; set; }

    public string? TERMINAL_BRAND { get; set; }

    public string? TERMINAL_MODELL { get; set; }

    public string TERMINAL_SERIENNR { get; set; } = null!;

    public string? TERMINAL_SW_BRAND { get; set; }

    public string? TERMINAL_SW_VERSION { get; set; }
}
