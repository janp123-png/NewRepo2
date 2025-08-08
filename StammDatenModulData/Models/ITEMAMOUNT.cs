using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ITEMAMOUNT
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string BON_ID { get; set; } = null!;

    public string POS_ZEILE { get; set; } = null!;

    public string TYP { get; set; } = null!;

    public string? UST_SCHLUESSEL { get; set; }

    public string? PF_BRUTTO { get; set; }

    public string? PF_NETTO { get; set; }

    public string? PF_UST { get; set; }
}
