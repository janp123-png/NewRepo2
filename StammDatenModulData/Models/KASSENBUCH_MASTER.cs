using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class KASSENBUCH_MASTER
{
    public int FILIALLE_NR { get; set; }

    public DateTime DATUM { get; set; }

    public string BUCHUNG_ART { get; set; } = null!;

    public string? FIRMA_NAME { get; set; }

    public float? BESTAND_ANFANG { get; set; }

    public float? BESTAND_ENDE { get; set; }

    public float? TOTAL_EINNAHMEN { get; set; }

    public float? TOTAL_AUSGABEN { get; set; }
}
