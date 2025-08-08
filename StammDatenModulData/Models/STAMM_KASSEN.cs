using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class STAMM_KASSEN
{
    public int FILIALLE_NR { get; set; }

    public string KASSE_ID { get; set; } = null!;

    public DateTime GULTIG_VON { get; set; }

    public string? KASSE_BRAND { get; set; }

    public string? KASSE_MODELL { get; set; }

    public string? KASSE_SERIENNR { get; set; }

    public string? KASSE_SW_BRAND { get; set; }

    public string? KASSE_SW_VERSION { get; set; }

    public string? KASSE_BASISWAEH_CODE { get; set; }

    public string? KEINE_UST_ZUORDNUNG { get; set; }

    public short? IST_KASSE { get; set; }

    public short? KASSE_NR { get; set; }

    public DateTime? GULTIG_BIS { get; set; }
}
