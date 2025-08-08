using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class MWST_SATZ
{
    public int FILIALLE_NR { get; set; }

    public int MWST_ID { get; set; }

    public float MWST { get; set; }

    public string? BEZEICHNUNG { get; set; }

    public string? BEZEICHNUNG2 { get; set; }

    public DateTime? GULTIG_VON { get; set; }

    public DateTime? GULTIG_BIS { get; set; }
}
