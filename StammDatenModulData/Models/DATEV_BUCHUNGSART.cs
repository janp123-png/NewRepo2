using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class DATEV_BUCHUNGSART
{
    public int FILIALLE_NR { get; set; }

    public string KONTO { get; set; } = null!;

    public string GEGEN_KONTO { get; set; } = null!;

    public string BEZEICHNUNG { get; set; } = null!;

    public string BERATERNUMMER { get; set; } = null!;

    public string MANDANTENNUMMER { get; set; } = null!;

    public string? WJ_BEGINN { get; set; }

    public int? SACHKONTENLANGE { get; set; }

    public string? BEARBEITE_KURZEL { get; set; }

    public string? SACHKONTENRAHMEN { get; set; }
}
