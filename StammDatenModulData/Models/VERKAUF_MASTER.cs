using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class VERKAUF_MASTER
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public long QUITTUNGSNUMMER { get; set; }

    public long? TSE_TRANSACTION_NR { get; set; }

    public string? KASSE_ID { get; set; }

    public string? BENUTZER_NR { get; set; }

    public string? BENUTZER_NAME { get; set; }

    public DateTime? DATUM { get; set; }

    public TimeSpan? ZEIT { get; set; }

    public float? TOTAL_SUMME { get; set; }

    public float? GEGEBEN { get; set; }

    public float? RUCK_GELD { get; set; }

    public string? VERKAUF_ART { get; set; }

    public string? BONN_STATUS { get; set; }

    public long? SITZUNG_NR { get; set; }

    public string? KUNDEN_NR { get; set; }

    public string? TSE_ID { get; set; }

    public string? KUNDE_NAME { get; set; }

    public string? KUNDE_TYP { get; set; }

    public string? KUNDE_STRASSE { get; set; }

    public string? KUNDE_PLZ { get; set; }

    public string? KUNDE_ORT { get; set; }

    public string? KUNDE_LAND { get; set; }

    public string? KUNDE_USTID { get; set; }

    public long? BON_ID { get; set; }

    public float? BAR_BETRAG { get; set; }

    public float? UNBAR_BETRAG { get; set; }

    public int? SENDEN { get; set; }
}
