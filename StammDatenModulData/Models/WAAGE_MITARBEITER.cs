using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class WAAGE_MITARBEITER
{
    public int FILIALLE_NR { get; set; }

    public int MITARBEITER_NR { get; set; }

    public string? MITARBEITER_NAME { get; set; }

    public string? PROFIL { get; set; }

    public string? PASSWORT { get; set; }

    public string? WAAGE_HERSTELLER { get; set; }
}
