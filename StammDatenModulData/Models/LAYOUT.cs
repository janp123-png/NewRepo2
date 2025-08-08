using System;
using System.Collections.Generic;

namespace StammDatenModulData.Models;

public partial class LAYOUT
{
    public int FILIALLE_NR { get; set; }

    public int KASSE_NR { get; set; }

    public string LAYOUT1 { get; set; } = null!;

    public string FORM { get; set; } = null!;

    public string CONTROL_TYPE { get; set; } = null!;

    public string CONTROL_NAME { get; set; } = null!;

    public string? CONTROL_TEXT { get; set; }

    public int? LOC_X { get; set; }

    public int? LOC_Y { get; set; }

    public int? WIDTH { get; set; }

    public int? HEIGTH { get; set; }

    public string? IMAGE { get; set; }

    public string? BACKGROUND_COLOR { get; set; }

    public string? FORE_COLOR { get; set; }

    public int? FONT_SIZE { get; set; }

    public string? FONT_STYLE { get; set; }

    public string? FUNKTION { get; set; }

    public int? FLAG { get; set; }
}
