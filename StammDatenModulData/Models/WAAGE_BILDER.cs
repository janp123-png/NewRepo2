using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class WAAGE_BILDER
{
    public int FILIALLE_NR { get; set; }

    public int BILD_POS { get; set; }

    public string? BILD_NAME { get; set; }

    public byte[]? BILD { get; set; }

    public string? SENDEN { get; set; }
}
