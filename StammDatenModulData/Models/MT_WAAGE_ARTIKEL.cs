using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class MT_WAAGE_ARTIKEL
{
    public int FILIALLE_NR { get; set; }

    public int ABTEILUNG_NR { get; set; }

    public int WG_NR { get; set; }

    public int ARTIKEL_NR { get; set; }

    public string? ARTIKEL_NAME { get; set; }

    public int? MWST { get; set; }

    public int? EK_PREIS { get; set; }

    public int? VK_PREIS { get; set; }

    public int? GEWINN { get; set; }

    public string? WAAGE_HERSTELLER { get; set; }

    public string? WIEGE_ARTIKEL { get; set; }

    public byte[]? BILD { get; set; }
}
