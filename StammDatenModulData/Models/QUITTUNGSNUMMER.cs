using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class QUITTUNGSNUMMER
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public string JAHR { get; set; } = null!;

    public long? QUITTUNG_NUMMER { get; set; }

    public long? BON_ID { get; set; }
}
