using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class CASH_PER_CURRENCY
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string ZAHLART_WAEH { get; set; } = null!;

    public string? ZAHLART_BETRAG_WAEH { get; set; }
}
