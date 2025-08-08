using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class MT_WAAGE_MITARBEITER
{
    public int FILIALLE_NR { get; set; }

    public int MITARBEITERNUMMER { get; set; }

    public string? NAME { get; set; }

    public string? WAAGE_HERSTELLER { get; set; }
}
