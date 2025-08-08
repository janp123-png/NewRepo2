using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class WARENGRUPPEN
{
    public int FILIALLE_NR { get; set; }

    public int WG_NUMMER { get; set; }

    public string? WG_NAME { get; set; }

    public byte[]? BILD { get; set; }

    public float? WG_MWST { get; set; }

    public int? PLU_ORDER { get; set; }

    public string? WG_ART { get; set; }

    public string? WG_WERT { get; set; }

    public float? TARAWERT { get; set; }

    public float? PLU_FARBE { get; set; }

    public float? VK_PREIS { get; set; }

    public string? RABATT_FAHIG { get; set; }

    public string? SENDEN { get; set; }
}
