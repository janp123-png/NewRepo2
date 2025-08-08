using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class PROTOKOLL
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public int PROTOKOLL_NR { get; set; }

    public DateTime DATUM { get; set; }

    public TimeSpan UHR_ZEIT { get; set; }

    public string FORM_NAME { get; set; } = null!;

    public string BEZEICHNUNG { get; set; } = null!;

    public string BENUTZER { get; set; } = null!;

    public string PROTOKOLL_ART { get; set; } = null!;
}
