using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class WAAGE_WARENGRUPPEN_TMP
{
    public int FILIALLE_NR { get; set; }

    public int ABTEILUNG_NR { get; set; }

    public int WG_NR { get; set; }

    public string WG_NAME { get; set; } = null!;

    public int? WG_MWST { get; set; }

    public string? WAAGE_HERSTELLER { get; set; }

    public DateTime DATUM { get; set; }

    public TimeSpan ZEIT { get; set; }

    public int? BENUTZER_NR { get; set; }

    public int? SENDEN { get; set; }
}
