using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class BERECHTIGUNGEN
{
    public int FILIALLE_NR { get; set; }

    public int MITARBEITER_NR { get; set; }

    public string BEZEICHNUNG { get; set; } = null!;

    public string? STATUS { get; set; }
}
