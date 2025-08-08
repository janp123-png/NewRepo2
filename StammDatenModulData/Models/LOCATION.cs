using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class LOCATION
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string LOC_NAME { get; set; } = null!;

    public string LOC_STRASSE { get; set; } = null!;

    public string LOC_PLZ { get; set; } = null!;

    public string? LOC_ORT { get; set; }

    public string? LOC_LAND { get; set; }

    public string? LOC_USTID { get; set; }
}
