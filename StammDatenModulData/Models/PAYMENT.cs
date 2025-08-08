using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class PAYMENT
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string? ZAHLART_TYP { get; set; }

    public string ZAHLART_NAME { get; set; } = null!;

    public string? Z_ZAHLART_BETRAG { get; set; }
}
