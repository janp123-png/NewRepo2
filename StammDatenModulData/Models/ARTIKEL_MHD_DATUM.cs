using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ARTIKEL_MHD_DATUM
{
    public string FILIALLE_NR { get; set; } = null!;

    public string ARTIKEL_NR { get; set; } = null!;

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string LIEFERANTEN_NAME { get; set; } = null!;

    public string ARTIKEL_LIEF_NR { get; set; } = null!;

    public DateTime MHD_DATUM { get; set; }

    public int? SENDEN { get; set; }
}
