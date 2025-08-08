using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class STAMM_TSE
{
    public int FILIALLE_NR { get; set; }

    public string TSE_SERIAL_NR { get; set; } = null!;

    public int TSE_ID { get; set; }

    public string? KASSE_ID { get; set; }

    public int? KASSE_NR { get; set; }

    public string? TSE_SIG_ALGO { get; set; }

    public string? TSE_ZEITFORMAT { get; set; }

    public string? TSE_PD_ENCODING { get; set; }

    public string? TSE_PUBLIC_KEY { get; set; }

    public string? TSE_ZERTIFIKAT_I { get; set; }

    public string? TSE_ZERTIFIKAT_II { get; set; }

    public DateTime? GULTIG_VON { get; set; }

    public DateTime? GULTIG_BIS { get; set; }

    public string? TSE_AKTIV { get; set; }
}
