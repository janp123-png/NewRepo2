using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class KASSEN
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public string? KASSE_NAME { get; set; }

    public string? KASSE_IP { get; set; }

    public string? PORT_NUMMER { get; set; }

    public string? KASSE_DATENBANK { get; set; }
}
