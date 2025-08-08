using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class KUNDEN
{
    public int FILIALLE_NR { get; set; }

    public int KUNDEN_NR { get; set; }

    public string? KUNDEN_NAME { get; set; }

    public string? KUNDEN_ART { get; set; }

    public string? STRASSE { get; set; }

    public string? PLZ { get; set; }

    public string? ORT { get; set; }

    public string? INHABER { get; set; }

    public string? TEL { get; set; }

    public string? FAX { get; set; }

    public string? BANK_NAME { get; set; }

    public string? IBAN { get; set; }

    public string? BIC { get; set; }

    public string? EMAIL { get; set; }

    public string? WEB { get; set; }

    public string? USTID { get; set; }

    public string? LAND { get; set; }

    public byte[]? LOGO { get; set; }
}
