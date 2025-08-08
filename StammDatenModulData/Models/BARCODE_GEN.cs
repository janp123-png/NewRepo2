using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class BARCODE_GEN
{
    public int FILIALLE_NR { get; set; }

    public int ARTIKEL_NR { get; set; }

    public string BARCODE_NR { get; set; } = null!;

    public string? ARTIKEL_BEZEICHNUNG { get; set; }
}
