using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class LIEFERANT_ARTIKEL
{
    public int FILIALLE_NR { get; set; }

    public string LIEFERANTEN_NR { get; set; } = null!;

    public string LIEFERANT_ARTIKEL_NR { get; set; } = null!;

    public string? BARCODE_NR { get; set; }

    public string ARTIKEL_NAME { get; set; } = null!;

    public string WARENGRUPPE { get; set; } = null!;

    public float? MWST { get; set; }

    public float? NETTO_EK { get; set; }

    public string? EINHEIT { get; set; }

    public int? INHALT { get; set; }
}
