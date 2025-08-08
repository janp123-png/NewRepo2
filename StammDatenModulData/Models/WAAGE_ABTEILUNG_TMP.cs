using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class WAAGE_ABTEILUNG_TMP
{
    public int FILIALLE_NR { get; set; }

    public int ABT_NR { get; set; }

    public string? ABTEILUNG_NAME { get; set; }

    public string? WAAGE_HERSTELLER { get; set; }

    public int? SENDEN { get; set; }
}
