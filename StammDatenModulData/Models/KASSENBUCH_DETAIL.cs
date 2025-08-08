using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class KASSENBUCH_DETAIL
{
    public int FILIALLE_NR { get; set; }

    public DateTime DATUM { get; set; }

    public string BUCHUNG_ART { get; set; } = null!;

    public int POS { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public float? MWST { get; set; }

    public float? EINNAHME { get; set; }

    public float? AUSGABE { get; set; }

    public float? BESTAND { get; set; }

    public string? KONTO { get; set; }

    public string? GEGEN_KONTO { get; set; }

    public string? SOLL_HABEN { get; set; }
}
