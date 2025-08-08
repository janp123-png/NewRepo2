using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ARTIKEL_TMP
{
    public int FILIALLE_NR { get; set; }

    public string ARTIKEL_NR { get; set; } = null!;

    public string? NAME { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public string? WARENGRUPPE { get; set; }

    public string? EINHEIT { get; set; }

    public int? VERPACKUNGSINHALT { get; set; }

    public float? MWST { get; set; }

    public float? NETTO_EK { get; set; }

    public float? BRUTTO_VK { get; set; }

    public string? PRODUKT_ART { get; set; }

    public float? BESTAND { get; set; }

    public string? BESTAND_REDUZIEREN { get; set; }

    public float? GEWINN_PROZENT { get; set; }

    public float? GEWINN_BETRAG { get; set; }

    public string? GEWICHTSARTIKEL { get; set; }

    public float? TARAWERT { get; set; }

    public string? MANUELLE_TARAWERT { get; set; }

    public float? ARTIKEL_GEWICHT { get; set; }

    public float? GRUND_GEWICHT { get; set; }

    public float? GRUND_PREIS { get; set; }

    public string? GRUND_GEWICHT_EINHEIT { get; set; }

    public string? ARTIKEL_GEWICHT_EINHEIT { get; set; }

    public string? BARCODE_ART { get; set; }

    public string? ANGEBOT { get; set; }

    public DateTime? ANGEBOT_DATUM_VON { get; set; }

    public DateTime? ANGEBOT_DATUM_BIS { get; set; }

    public float? ANGEBOT_PREIS { get; set; }

    public string? LIEFERANTEN { get; set; }

    public float? PFAND { get; set; }

    public DateTime? MHD_DATUM { get; set; }

    public byte[]? BILD { get; set; }

    public string? HERSTELLER { get; set; }

    public DateTime? UPDATED { get; set; }

    public string? RABATT_FAHIG { get; set; }

    public string? JUGEND_SCHUTZ { get; set; }

    public int? JUGEND_ALTER { get; set; }

    public string? WG_ID { get; set; }

    public string? SENDEN { get; set; }

    public int? GUTSCHEIN_GULTIG_BIS { get; set; }

    public string? ARTIKEL_NR_FUER_GUTSCHEIN { get; set; }

    public string? PACKUNG_EAN { get; set; }

    public float? PACKUNG_VK { get; set; }

    public int? AKTIV { get; set; }

    public string? AUSLAUF { get; set; }

    public string? BESTELL_NUMMER { get; set; }

    public string? E_LABEL_NR { get; set; }

    public string? LIEFERANTEN_ARTIKEL_NR { get; set; }

    public int? BUNDLE_ANZAHL { get; set; }

    public float? BUNDLE_PREIS { get; set; }
}
