using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class SUBITEM
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string BON_ID { get; set; } = null!;

    public string POS_ZEILE { get; set; } = null!;

    public string ZI_ART_NR { get; set; } = null!;

    public string? ZI_GTIN { get; set; }

    public string? ZI_NAME { get; set; }

    public string? ZI_WARENGR_ID { get; set; }

    public string? ZI_WARENGR { get; set; }

    public string? ZI_MENGE { get; set; }

    public string? ZI_FAKTOR { get; set; }

    public string? ZI_EINHEIT { get; set; }

    public string? ZI_UST_SCHLUESSEL { get; set; }

    public string? ZI_BASISPREIS_BRUTTO { get; set; }

    public string? ZI_BASISPREIS_NETTO { get; set; }

    public string? ZI_BASISPREIS_UST { get; set; }
}
