using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class Z_BERICHT
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public string? KASSE_ID { get; set; }

    public DateTime? DATUM { get; set; }

    public TimeSpan? ANFANGS_ZEIT { get; set; }

    public DateTime? DATUM_ENDE { get; set; }

    public TimeSpan? END_ZEIT { get; set; }

    public int? BERICHT_STATUS { get; set; }

    public string? FIRM_NAME { get; set; }

    public string? STRASSE { get; set; }

    public string? PLZ { get; set; }

    public string? ORT { get; set; }

    public string? LAND { get; set; }

    public string? USTID { get; set; }

    public string? INHABER { get; set; }

    public string? STNR { get; set; }

    public int? Z_START_ID { get; set; }

    public int? Z_ENDE_ID { get; set; }

    public float? Z_SE_ZAHLUNGEN { get; set; }

    public float? Z_SE_BARZAHLUNGEN { get; set; }

    public float? BAR_VERKAUF_SOLL { get; set; }

    public float? BAR_VERKAUF_IST { get; set; }

    public float? BAR_DIFFERENZ { get; set; }

    public float? EC_VERKAUF_SOLL { get; set; }

    public float? ANFANGSBESTAND { get; set; }

    public float? BAR_ENTNAHMEN { get; set; }

    public float? BAR_EINLAGEN { get; set; }

    public long? BON_ID_START { get; set; }

    public long? BON_ID_ENDE { get; set; }

    public float? BAR_REST_BETRAG { get; set; }

    public int? DSFINVK_STATUS { get; set; }
}
