using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ARTIKEL_LIEFERANTEN
{
    public string FILIALLE_NR { get; set; } = null!;

    public string ARTIKEL_EAN_NR { get; set; } = null!;

    public string ARTIKEL_NR { get; set; } = null!;

    public string LIEFERANTEN_NAME { get; set; } = null!;

    public string? ARTIKEL_NAME { get; set; }

    public float? EK_PREIS { get; set; }

    public int? SENDEN { get; set; }
}
