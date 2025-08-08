using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class TRANSACTIONS_VAT
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string BON_ID { get; set; } = null!;

    public string UST_SCHLUESSEL { get; set; } = null!;

    public string? BON_BRUTTO { get; set; }

    public string? BON_NETTO { get; set; }

    public string? BON_UST { get; set; }
}
