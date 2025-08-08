using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class ARTIKEL_ETIKET
{
    public int FILIALLE_NR { get; set; }

    public string ARTIKEL_NR { get; set; } = null!;

    public string? ARTIKEL_NAME { get; set; }

    public string? ZWEITE_BEZEICHNUNG { get; set; }

    public string? PFAND { get; set; }

    public string? WARENGRUPPE { get; set; }

    public string? VK_PREIS { get; set; }

    public string? GEWICHT { get; set; }

    public byte[]? BILD { get; set; }

    public string? HERSTELLER { get; set; }

    public string? GRUND_PREIS { get; set; }

    public DateTime? DATUM { get; set; }

    public TimeSpan? ZEIT { get; set; }

    public string? BENUTZER_NR { get; set; }

    public string? ANGEBOT { get; set; }

    public float? ANGEBOT_PREIS { get; set; }

    public string? LIEFERANTEN { get; set; }

    public string? AUSLAUF { get; set; }
}
