using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class VERKAUF_MWST
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public int SITZUNG_NR { get; set; }

    public long QUITTUNGSNUMMER { get; set; }

    public float MWST { get; set; }

    public long? TSE_TRANSACTION_NR { get; set; }

    public string? KASSE_ID { get; set; }

    public DateTime? DATUM { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public float? ENTHALTENE_MWST { get; set; }

    public float? NETTO { get; set; }

    public float? BRUTTO { get; set; }

    public string? TSE_ID { get; set; }

    public int? SENDEN { get; set; }

    public long? BON_ID { get; set; }
}
