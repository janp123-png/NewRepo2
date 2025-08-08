using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class WAAGE_UMSATZ
{
    public int FILIALLE_NR { get; set; }

    public string WAAGE_TRANSAKTION_NR { get; set; } = null!;

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string? WAAGE_HERSTELLER { get; set; }

    public float? BETRAG { get; set; }
}
