using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class LINE
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string BON_ID { get; set; } = null!;

    public string POS_ZEILE { get; set; } = null!;

    public string? GUTSCHEIN_NR { get; set; }

    public string? ARTIKELTEXT { get; set; }

    public string? POS_TERMINAL_ID { get; set; }

    public string? GV_TYP { get; set; }

    public string? GV_NAME { get; set; }

    public string? INHAUS { get; set; }

    public string? P_STORNO { get; set; }

    public string? AGENTUR_ID { get; set; }

    public string? ART_NR { get; set; }

    public string? GTIN { get; set; }

    public string? WARENGR_ID { get; set; }

    public string? WARENGR { get; set; }

    public string? MENGE { get; set; }

    public string? FAKTOR { get; set; }

    public string? EINHEIT { get; set; }

    public string? STK_BR { get; set; }
}
