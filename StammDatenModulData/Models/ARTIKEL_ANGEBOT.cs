using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ARTIKEL_ANGEBOT
{
    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string FILIALLE_NR { get; set; } = null!;

    public string? ARTIKEL_NR { get; set; }

    public string? ARTIKEL_NAME { get; set; }

    public string? MWST { get; set; }

    public float? EK_PREIS { get; set; }

    public float VK_PREIS { get; set; }

    public DateTime ANGEBOT_DATUM_VON { get; set; }

    public DateTime ANGEBOT_DATUM_BIS { get; set; }

    public float ANGEBOT_PREIS { get; set; }

    public string? HERSTELLER { get; set; }

    public int? SENDEN { get; set; }
}
