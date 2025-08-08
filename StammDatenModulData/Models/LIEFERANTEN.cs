using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class LIEFERANTEN
{
    public int FILIALLE_NR { get; set; }

    public int LIEFERANTEN_NR { get; set; }

    public string? LIEFERANTEN_NAME { get; set; }

    public string? STRASSE { get; set; }

    public string? PLZ { get; set; }

    public string? INHABER { get; set; }

    public string? TEL { get; set; }

    public string? FAX { get; set; }

    public string? BANK_NAME { get; set; }

    public string? IBAN { get; set; }

    public string? BIC { get; set; }

    public string? ORT { get; set; }
}
