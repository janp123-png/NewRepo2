using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class SONDER_BARCODE
{
    public int FILIALLE_NR { get; set; }

    public string SZSCANFLAG { get; set; } = null!;

    public short NCODEDIGITS { get; set; }

    public short BVALUECHECKDIGITFG { get; set; }

    public short BCDINSEARCHCODE0 { get; set; }

    public short DDROPVARDIGITSFORSEARCHKEY { get; set; }

    public short ENPRNTYPE { get; set; }

    public short ENSCANTYPE { get; set; }

    public short ENDATASOURCE { get; set; }

    public decimal? DECIVARDIVISORPRICE { get; set; }

    public decimal? DECIVARDIVISORWEIGHT { get; set; }

    public int? NCUTOFFDIGIT { get; set; }

    public short BEANPLUTYPEFG { get; set; }

    public short BSCANDINAVIANBARCODEFG { get; set; }

    public string? SZPRNFLAG { get; set; }

    public short? NPRNCODEDIGITS { get; set; }

    public short BPRNCHECKDIGITFG { get; set; }
}
