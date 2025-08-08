using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class MITARBEITER
{
    public int FILIALLE_NR { get; set; }

    public int MITARBEITER_NR { get; set; }

    public string? NAME { get; set; }

    public string? VORNAME { get; set; }

    public string? KENNWORT { get; set; }

    public string? STATUS { get; set; }
}
