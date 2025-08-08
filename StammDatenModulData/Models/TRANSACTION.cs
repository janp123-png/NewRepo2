using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class TRANSACTION
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string BON_ID { get; set; } = null!;

    public string? BON_NR { get; set; }

    public string? BON_TYP { get; set; }

    public string? BON_NAME { get; set; }

    public string? TERMINAL_ID { get; set; }

    public string? BON_STORNO { get; set; }

    public string? BON_START { get; set; }

    public string? BON_ENDE { get; set; }

    public string? BEDIENER_ID { get; set; }

    public string? BEDIENER_NAME { get; set; }

    public string? UMS_BRUTTO { get; set; }

    public string? KUNDE_NAME { get; set; }

    public string? KUNDE_ID { get; set; }

    public string? KUNDE_TYP { get; set; }

    public string? KUNDE_STRASSE { get; set; }

    public string? KUNDE_PLZ { get; set; }

    public string? KUNDE_ORT { get; set; }

    public string? KUNDE_LAND { get; set; }

    public string? KUNDE_USTID { get; set; }

    public string? BON_NOTIZ { get; set; }
}
