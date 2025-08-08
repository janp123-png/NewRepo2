using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class DATAPAYMENT
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string BON_ID { get; set; } = null!;

    public string? ZAHLART_TYP { get; set; }

    public string ZAHLART_NAME { get; set; } = null!;

    public string? ZAHLWAEH_CODE { get; set; }

    public string? ZAHLWAEH_BETRAG { get; set; }

    public string? BASISWAEH_BETRAG { get; set; }
}
