using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ZVT_KASSENSCHNITT
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public string KASSE_ID { get; set; } = null!;

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string? KASSENSCHNITT { get; set; }

    public int? SENDEN { get; set; }
}
