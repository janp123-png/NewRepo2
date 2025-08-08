using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class GESTRO_DATUM
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public DateTime DATUM { get; set; }

    public TimeSpan? ZEIT { get; set; }
}
