using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class MT_WAAGE_WARENGRUPPE
{
    public int FILIALLE_NR { get; set; }

    public int ABTEILUNG_NR { get; set; }

    public int WG_NR { get; set; }

    public string? WG_NAME { get; set; }

    public int? WG_MWST { get; set; }

    public string? WAAGE_HERSTELLER { get; set; }

    public byte[]? BILD { get; set; }
}
