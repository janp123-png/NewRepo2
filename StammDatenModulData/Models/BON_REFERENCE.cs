using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class BON_REFERENCE
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string BON_ID { get; set; } = null!;

    public string POS_ZEILE { get; set; } = null!;

    public string REF_TYP { get; set; } = null!;

    public string REF_NAME { get; set; } = null!;

    public string? REF_DATUM { get; set; }

    public string? REF_Z_KASSE_ID { get; set; }

    public string? REF_Z_NR { get; set; }

    public string? REF_BON_ID { get; set; }
}
