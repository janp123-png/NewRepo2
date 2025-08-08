using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class VAT
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string UST_SCHLUESSEL { get; set; } = null!;

    public string? UST_SATZ { get; set; }

    public string? UST_BESCHR { get; set; }
}
