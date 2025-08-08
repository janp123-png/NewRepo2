using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class CASHREGISTER
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string? KASSE_BRAND { get; set; }

    public string KASSE_MODELL { get; set; } = null!;

    public string? KASSE_SERIENNR { get; set; }

    public string? KASSE_SW_BRAND { get; set; }

    public string? KASSE_SW_VERSION { get; set; }

    public string? KASSE_BASISWAEH_CODE { get; set; }

    public string? KEINE_UST_ZUORDNUNG { get; set; }
}
