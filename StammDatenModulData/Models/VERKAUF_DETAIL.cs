using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class VERKAUF_DETAIL
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public long QUITTUNGSNUMMER { get; set; }

    public long? TSE_TRANSACTION_NR { get; set; }

    public string? KASSE_ID { get; set; }

    public string? BENUTZER_NR { get; set; }

    public DateTime DATUM { get; set; }

    public TimeSpan? ZEIT { get; set; }

    public short POS { get; set; }

    public string? ARTIKEL_NR { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public string? WARENGRUPPE { get; set; }

    public float? MWST { get; set; }

    public float? MENGE { get; set; }

    public float? VK_PREIS { get; set; }

    public float? TOTAL_VK_PREIS { get; set; }

    public float? GEWINN { get; set; }

    public string? RABATT_FAHIG { get; set; }

    public string? VERKAUF_ART { get; set; }

    public string? BONN_STATUS { get; set; }

    public long? SITZUNG_NR { get; set; }

    public string? MWST_BEZEICHNUNG { get; set; }

    public string? EINHEIT { get; set; }

    public string? KUNDEN_NR { get; set; }

    public float? TARA_WERT { get; set; }

    public float? MENGE_WERT { get; set; }

    public string? LIEFERANTEN { get; set; }

    public string? GVF { get; set; }

    public string? POS_STORNO { get; set; }

    public long? REF_BON { get; set; }

    public short? REF_BON_POS { get; set; }

    public string? REF_RABATT_POS { get; set; }

    public string? REF_KASSE_ID { get; set; }

    public string? REF_Z_ID { get; set; }

    public string? REF_BON_ID { get; set; }

    public DateTime? REF_DATUM { get; set; }

    public int? REF_EXT_STORNIERT { get; set; }

    public string? WARENGR_ID { get; set; }

    public string? GTIN { get; set; }

    public string? TSE_ID { get; set; }

    public int? SENDEN { get; set; }

    public string? GUTSCHEIN_NR { get; set; }

    public string? ARTIKEL_NR_FUER_GUTSCHEIN { get; set; }

    public int? STORNIERTE_MENGE { get; set; }

    public string? BESTAND_REDUZIEREN { get; set; }

    public int? IST_BESTAND_REDUZIERT { get; set; }

    public long? BON_ID { get; set; }

    public long? REF_BON_TMP { get; set; }

    public string? STORNO_ART { get; set; }
}
