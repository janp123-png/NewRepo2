using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class MT_WAAGE_ABTEILUNG
{
    public int FILIALLE_NR { get; set; }

    public int ABTEILUNG_NR { get; set; }

    public string? ABTEILUNG_NAME { get; set; }

    public string? WAAGE_HERSTELLER { get; set; }
}
