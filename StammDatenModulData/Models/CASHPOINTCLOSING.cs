using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class CASHPOINTCLOSING
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string? Z_BUCHUNGSTAG { get; set; }

    public string? TAXONOMIE_VERSION { get; set; }

    public string? Z_START_ID { get; set; }

    public string? Z_ENDE_ID { get; set; }

    public string? NAME { get; set; }

    public string? STRASSE { get; set; }

    public string? PLZ { get; set; }

    public string? ORT { get; set; }

    public string? LAND { get; set; }

    public string? STNR { get; set; }

    public string? USTID { get; set; }

    public string? Z_SE_ZAHLUNGEN { get; set; }

    public string? Z_SE_BARZAHLUNGEN { get; set; }
}
