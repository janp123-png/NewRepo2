using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class PA
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string AGENTUR_ID { get; set; } = null!;

    public string? AGENTUR_NAME { get; set; }

    public string? AGENTUR_STRASSE { get; set; }

    public string? AGENTUR_PLZ { get; set; }

    public string? AGENTUR_ORT { get; set; }

    public string? AGENTUR_LAND { get; set; }

    public string? AGENTUR_STNR { get; set; }

    public string? AGENTUR_USTID { get; set; }
}
