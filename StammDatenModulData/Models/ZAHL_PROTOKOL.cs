using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ZAHL_PROTOKOL
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int Z_BERICHT_NR { get; set; }

    public string KASSE_ID { get; set; } = null!;

    public DateTime DATUM { get; set; }

    public int POS { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public int? ANZAHL { get; set; }

    public float? BETRAG { get; set; }

    public int? BENUTZER_NR { get; set; }
}
