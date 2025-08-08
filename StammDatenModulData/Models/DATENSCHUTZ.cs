using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class DATENSCHUTZ
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public string GESTRO_ID { get; set; } = null!;

    public string? GESTRO_LIZENZ { get; set; }

    public string? FIRMEN_NAME { get; set; }

    public string? FIRMEN_STRASSE { get; set; }

    public string? FIRMEN_PLZ { get; set; }

    public string? FIRMEN_ORT { get; set; }

    public string? FIRMEN_TEL { get; set; }

    public string? FIRMEN_EMAIL { get; set; }

    public string? DATENSCHUTZ_TEXT { get; set; }

    public string? DATENSCHUTZ_AKZEPTIEREN { get; set; }

    public DateTime? DATUM { get; set; }

    public int? STATUS { get; set; }
}
