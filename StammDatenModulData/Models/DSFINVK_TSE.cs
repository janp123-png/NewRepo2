using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class DSFINVK_TSE
{
    public DateTime Z_BERICHT_DATUM { get; set; }

    public string Z_KASSE_ID { get; set; } = null!;

    public string Z_ERSTELLUNG { get; set; } = null!;

    public string Z_NR { get; set; } = null!;

    public string TSE_ID { get; set; } = null!;

    public string TSE_SERIAL { get; set; } = null!;

    public string? TSE_SIG_ALGO { get; set; }

    public string? TSE_ZEITFORMAT { get; set; }

    public string? TSE_PD_ENCODING { get; set; }

    public string? TSE_PUBLIC_KEY { get; set; }

    public string? TSE_ZERTIFIKAT_I { get; set; }

    public string? TSE_ZERTIFIKAT_II { get; set; }
}
