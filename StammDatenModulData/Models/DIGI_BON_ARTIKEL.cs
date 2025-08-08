using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class DIGI_BON_ARTIKEL
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int WAAGE_NR { get; set; }

    public int TRANSACTION_NR { get; set; }

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public string? BEDIENER { get; set; }

    public string? BONTYPE { get; set; }

    public string BARCODE { get; set; } = null!;

    public int POS { get; set; }

    public string? PLU_NR { get; set; }

    public string? PLU_NAME { get; set; }

    public string? PLU_WG { get; set; }

    public float? MWST { get; set; }

    public float? VK_PREIS { get; set; }

    public float? GEWICHT { get; set; }

    public float? TOTAL_PREIS { get; set; }

    public string? STORNIERT { get; set; }

    public int? VERKAUFT { get; set; }

    public float? TARAWERT { get; set; }

    public string? EINHEIT { get; set; }

    public string? SENDEN { get; set; }
}
