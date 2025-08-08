using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class FIRMEN_DATEN
{
    public int FILIALLE_NR { get; set; }

    public string? FIRMA_NAME { get; set; }

    public string? STRASSE { get; set; }

    public string? PLZ { get; set; }

    public string? ORT { get; set; }

    public string? LAND { get; set; }

    public string? TEL { get; set; }

    public string? FAX { get; set; }

    public string? EMAIL { get; set; }

    public string? URL { get; set; }

    public string? STEUER_NR { get; set; }

    public string? USTID { get; set; }

    public string? INHABER { get; set; }

    public byte[]? LOGO { get; set; }

    public string? BANK { get; set; }

    public string? IBAN { get; set; }

    public string? BIC { get; set; }

    public string? HRB { get; set; }

    public string? GLAUBIGER_ID { get; set; }

    public string? E_LABEL_STOREID { get; set; }
}
