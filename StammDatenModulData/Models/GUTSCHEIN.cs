using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class GUTSCHEIN
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public string ARTIKEL_NR { get; set; } = null!;

    public int GUTSCHEIN_NR { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public string? ZWECK { get; set; }

    public string? TEIL_LOSUNG { get; set; }

    public float? GUTSCHEIN_WERT { get; set; }

    public float? EINGELOSTER_WERT { get; set; }

    public float? REST_WERT { get; set; }

    public float? MWST { get; set; }

    public string? ZWECK_ARTIKEL_NR { get; set; }

    public string? ZWECK_ARTIKEL_NAME { get; set; }

    public short? STATUS { get; set; }

    public string? GUTSCHEIN_BARCODE { get; set; }

    public string? GUTSCHEIN_ART { get; set; }

    public DateTime? DATUM_VON { get; set; }

    public DateTime? DATUM_BIS { get; set; }

    public string? SENDEN { get; set; }
}
