using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class BUSINESSCASE
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string? GV_TYP { get; set; }

    public string GV_NAME { get; set; } = null!;

    public string? AGENTUR_ID { get; set; }

    public string UST_SCHLUESSEL { get; set; } = null!;

    public string? Z_UMS_BRUTTO { get; set; }

    public string? Z_UMS_NETTO { get; set; }

    public string? Z_UST { get; set; }
}
