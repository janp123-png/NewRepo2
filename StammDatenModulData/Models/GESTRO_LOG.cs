using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class GESTRO_LOG
{
    public long LOG_NR { get; set; }

    public string TERMINAL_ID { get; set; } = null!;

    public DateTime? DATUM { get; set; }

    public TimeSpan? ZEIT { get; set; }

    public string? BEDIENER { get; set; }

    public string? FIRMEN_NAME { get; set; }

    public string? STRASSE { get; set; }

    public int? PLZ { get; set; }

    public string? ORT { get; set; }

    public string? LOG_BEZEICHNUNG { get; set; }

    public int? STATUS { get; set; }

    public short? FILIALLE_NR { get; set; }
}
