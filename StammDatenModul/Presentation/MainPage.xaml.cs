using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.UI;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml.Input;
using StammDatenModul.Config;
using StammDatenModul.Models;
using StammDatenModul.Utility;
using StammDatenModul.Validator;
using StammDatenModulData.Data;
using StammDatenModulData.Models;

namespace StammDatenModul.Presentation;

public sealed partial class MainPage : Page
{
    MyDbContext _context = new MyDbContext();
    List<string> _notAllowedEntityTypes = new();
    Dictionary<string, List<Rule>> _rules = new();
    static List<string> _boolTable = new();
    static List<string> _boolTableInt = new();
    public MainPage()
    {
        this.InitializeComponent();
        CBTabelle.ItemsSource = EntityTypes();
        var tempEntityTypes = SecureDecryptHelper.ReadContainerFromFile("notAllowedEntityTypes.geConf");
        var tempRules = SecureDecryptHelper.ReadContainerFromFile("ValidationRules.geConf");
        var tempBoolTable = SecureDecryptHelper.ReadContainerFromFile("bool.geConf");
        var tempBoolTableInt = SecureDecryptHelper.ReadContainerFromFile("boolInt.geConf");
        
        
        _notAllowedEntityTypes = JsonSerializer.Deserialize<List<string>>(tempEntityTypes);
        _boolTable = JsonSerializer.Deserialize<List<string>>(tempBoolTable);
        _boolTableInt = JsonSerializer.Deserialize<List<string>>(tempBoolTable);
        _rules = JsonSerializer.Deserialize<Dictionary<string, List<Rule>>>(
            tempRules,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });        
    }
    public List<string> EntityTypes()
    {
        List<string> entityTypes = new List<string>();


        var EntityTypes = typeof(MyDbContext).Assembly
     .GetTypes()
     .Where(t => t.IsClass && t.Namespace == "StammDatenModulData.Models")
     .ToList();
        foreach (var type in EntityTypes)
        {
            if (_notAllowedEntityTypes.Contains(type.Name))
                continue;
            entityTypes.Add(type.Name);
        }


        return entityTypes;
    }
    public static List<string> GetPropeties(string entityType)
    {
        List<string> properties = new List<string>();
        var type = typeof(MyDbContext).Assembly
     .GetTypes()
     .FirstOrDefault(t => t.IsClass && t.Namespace == "StammDatenModulData.Models" && t.Name == entityType);
        if (type != null)
        {
            var propertyInfos = type.GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                properties.Add(propertyInfo.Name);
            }
        }
        return properties;
    }
    public static List<ColumnDefinitionDatabase> GetDateType(string entity)
    {
        List<ColumnDefinitionDatabase> datetype = new List<ColumnDefinitionDatabase>();
        var type = typeof(MyDbContext).Assembly
            .GetTypes()
            .FirstOrDefault(t => t.IsClass && t.Namespace == "StammDatenModulData.Models" && t.Name == entity);
        if (type != null)
        {

            var propertyInfos = type.GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {

                var temp = new ColumnDefinitionDatabase();
                temp.Name = propertyInfo.Name;
                string[] temptype = propertyInfo.PropertyType.ToString().Split('[');
                if (temptype[0] == "System.Nullable`1")
                {
                    temp.IsNullable = true;
                    temp.DataType = TypeDefinition(EntferneLetztesZeichen(temptype[1]));
                }
                else
                {
                    temp.IsNullable = false;
                    temp.DataType = TypeDefinition(temptype[0]);
                }
                datetype.Add(temp);
            }
        }
        return datetype;
    }
    static string EntferneLetztesZeichen(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length == 1)
            return string.Empty;

        return input.Substring(0, input.Length - 1);
    }
    public static Type TypeDefinition(string temp)
    {
        return Type.GetType(temp) ?? typeof(object); // fallback auf object
    }
    public void BTNAuswahl(object sender, EventArgs e)
    {
        LöscheAlleAußer(TabellenMaske, "ZurueckNeu");
        LöscheAlleAußer(Suchen, "ZurueckSuchen");

        if (sender is Button neu)
        {
            if (neu.Name == "Neu")
            {
                Button tempneu = new();
                tempneu.Name = "Speichern";
                tempneu.Content = "Speichern";
                tempneu.Click += Speichern;
                TabellenMaske.Add(tempneu);
            }
            else if (neu.Name == "SearchDB")
            {
                Button tempneu = new();
                tempneu.Name = "Suchen";
                tempneu.Content = "Suchen";
                tempneu.Click += DatabaseSearch;
                TabellenMaske.Add(tempneu);
            }
        }
        ElementeAusblenden(TabellenMaske);
        List<string> properties = GetPropeties(CBTabelle.SelectedItem.ToString()!);
        List<ColumnDefinitionDatabase> datetype = GetDateType(CBTabelle.SelectedItem.ToString()!);
        List<UIElement> uiElements = new();
        foreach (var x in datetype)
        {
            uiElements.Add(new TextBlock() { Text = x.Name.Replace('_', ' ') });
            uiElements.Add(iElement(x));
        }
        foreach (var element in uiElements)
        {
            if (element != null)
            {
                TabellenMaske.Add(element);
                element.Visibility = Visibility.Visible;
            }
        }
    }
    public static void LöscheAlleAußer(StackPanel panel, string buttonName1)
    {
        // Erst sammeln, was gelöscht werden soll (Children darf während der Iteration nicht verändert werden)
        var zuLöschen = panel.Children
            .Where(child =>
                child is FrameworkElement fe &&
                fe.Name != buttonName1
               )
            .ToList();

        // Dann löschen
        foreach (var element in zuLöschen)
        {
            panel.Children.Remove(element);
        }
    }
    public void BTNZurueck(object sender, EventArgs e)
    {
        ElementeAusblenden(Auswahl);
    }
    public void BTNNeu_Click(object sender, RoutedEventArgs e)
    {
        // Hier können Sie die Logik zum Hinzufügen eines neuen Eintrags implementieren
        // Zum Beispiel: Öffnen Sie ein neues Fenster oder eine Eingabemaske



    }
    public static UIElement iElement(ColumnDefinitionDatabase type)
    {
        // Nullable-Typen extrahieren (z. B. System.Nullable`1[System.Int32] -> System.Int32)
        foreach (var x in _boolTable)
        {
            if (type.Name == x)
            {
                return new CheckBox { Tag = type.Name };
            }
        }
        foreach (var x in _boolTableInt)
        {
            if (type.Name == x)
            {
                return new CheckBox { Tag = type.Name };
            }
        }
        if (type.DataType == typeof(string))
            return new TextBox { Tag = type.Name };

        if (type.DataType == typeof(char))
            return new TextBox { MaxLength = 1, Tag = type.Name };

        if (type.DataType == typeof(short) ||
            type.DataType == typeof(int) ||
            type.DataType == typeof(long) ||
            type.DataType == typeof(ushort) ||
            type.DataType == typeof(uint) ||
            type.DataType == typeof(ulong) ||
            type.DataType == typeof(byte) ||
            type.DataType == typeof(sbyte))
        {
            return new TextBox
            {
                InputScope = new InputScope
                {
                    Names = { new InputScopeName(InputScopeNameValue.Number) }
                },
                PlaceholderText = "Zahl eingeben",
                Tag = type.Name
            };
        }

        if (type.DataType == typeof(decimal) ||
            type.DataType == typeof(double) ||
            type.DataType == typeof(float))
        {
            return new TextBox
            {
                InputScope = new InputScope
                {
                    Names = { new InputScopeName(InputScopeNameValue.Number) }
                },
                PlaceholderText = "Kommazahl eingeben",
                Tag = type.Name
            };
        }

        if (type.DataType == typeof(bool))
            return new CheckBox { Tag = type.Name };

        if (type.DataType == typeof(DateTime))
            return new DatePicker { Tag = type.Name };

        if (type.DataType == typeof(TimeSpan))
        {
            return new TextBox
            {
                PlaceholderText = "hh:mm:ss",
                Tag = type.Name
            };
        }

        if (type.DataType == typeof(Guid))
        {
            return new TextBox
            {
                PlaceholderText = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
                Tag = type.Name
            };
        }

        if (type.DataType == typeof(object))
            return new TextBlock { Text = "[Objekt]", Tag = type.Name.Replace('_', ' ') };

        return new TextBlock { Text = $"Nicht unterstützter Typ: {type.DataType}", Tag = type.Name };
    }
    public void ElementeAusblenden(StackPanel temp)
    {
        Auswahl.Visibility = Visibility.Collapsed;
        TabellenMaske.Visibility = Visibility.Collapsed;
        Suchen.Visibility = Visibility.Collapsed;
        ErgebnisPanel.Visibility = Visibility.Collapsed;
        EditPanel.Visibility = Visibility.Collapsed;

        temp.Visibility = Visibility.Visible;
    }
    public void Speichern(object sender, EventArgs e)
    {

        var tempTabelle = CBTabelle.SelectedItem as string;
        var temp = EingabenSammeln(TabellenMaske);
        if (temp.Count == 0)
        {
            // Fehlermeldung anzeigen oder abbrechen
            return;
        }
        SpeichereDynamischAsync(tempTabelle, temp);
    }
    public void DatabaseSearch(object sender, EventArgs e)
    {
        // CBTabelle.SelectedItem kann null sein, daher mit null-Prüfung und Typprüfung
        string? ausgewaehlterName = CBTabelle.SelectedItem as string;
        if (string.IsNullOrWhiteSpace(ausgewaehlterName))
        {
            // Fehlermeldung anzeigen oder abbrechen
            return;
        }

        Type? typ = typeof(MyDbContext).Assembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == ausgewaehlterName);

        if (typ == null)
        {
            // Fehlermeldung anzeigen oder abbrechen
            return;
        }

        var filter = EingabenSammeln(TabellenMaske);

        var methode = typeof(DynamischeDatenbankSuche)
                      .GetMethod("Suche", BindingFlags.Public | BindingFlags.Static)
                      ?.MakeGenericMethod(typ);

        if (methode != null)
        {
            var ergebnisse = methode.Invoke(null, new object[] { _context, filter });

            if (ergebnisse is IEnumerable daten)
            {
                var liste = daten.Cast<object>().ToList();
                foreach (var item in liste)
                {
                    Debug.WriteLine(item);
                    Console.WriteLine(item);
                }
                LöscheAlleAußer(Suchen, "ZurueckSuchen");
                ElementeAusblenden(ErgebnisPanel);

                ZeigeErgebnisse(liste);
            }
        }
    }
    public static Dictionary<string, object> EingabenSammeln(StackPanel panel)
    {
        var werte = new Dictionary<string, object>();

        foreach (var element in panel.Children)
        {
            switch (element)
            {
                case Button:
                    break; // Buttons ignorieren

                case TextBox tb when !string.IsNullOrWhiteSpace(tb.Text):
                    if (tb.Tag is string spalte1)
                        werte[spalte1] = tb.Text.Trim(); // Noch kein Cast – wird später von der Suche interpretiert
                    break;

                case CheckBox cb when cb.IsChecked.HasValue:
                    {
                        if (cb.Tag is string spalte)
                        {
                            if (_boolTable.Contains(spalte))
                            {
                                // Als String speichern
                                werte[spalte] = cb.IsChecked.Value ? "JA" : "NEIN";
                            }
                            else if (_boolTableInt.Contains(spalte)) 
                            {
                                werte[spalte]= cb.IsChecked.Value ? 1 : 0;  
                            }
                            else
                            {
                                // Als bool speichern
                                werte[spalte] = cb.IsChecked.Value;
                            }
                        }
                    }
                    break;


                case DatePicker dp when dp.SelectedDate.HasValue:
                if (dp.Tag is string spalte3)
                    werte[spalte3] = dp.SelectedDate.Value;
                break;

            default:
                // Falls du weitere UI-Typen wie TimePicker o.ä. ergänzen willst
                break;
            }
        }

        return werte;
    }
    public void ZeigeErgebnisse(IEnumerable<object> daten)
    {
        ErgebnisPanel.Children.Clear();

        var liste = daten.ToList();
        if (!liste.Any()) return;

        var typ = liste.First().GetType();
        var props = typ.GetProperties();

        // Maximal 11 Spaltennamen (Überschriften)
        var headerTexte = props.Take(10).Select(p => p.Name).Prepend("#").ToList();

        var tablePanel = new StackPanel
        {
            Orientation = Orientation.Vertical,
            Margin = new Thickness(0),
        };

        // Header-Zeile hinzufügen
        tablePanel.Children.Add(ErzeugeZeile(headerTexte, istHeader: true));

        for (int i = 0; i < liste.Count; i++)
        {
            var item = liste[i];
            var werte = props.Take(10).Select(p => p.GetValue(item)?.ToString() ?? "").ToList();
            werte.Insert(0, (i + 1).ToString()); // Nummerierung als Button
            tablePanel.Children.Add(ErzeugeZeile(werte, istHeader: false, datenzeile: item));
        }

        ErgebnisPanel.Children.Add(tablePanel);
    }
    private Grid ErzeugeZeile(List<string> inhalte, bool istHeader = false, object? datenzeile = null)
    {
        var grid = new Grid
        {
            HorizontalAlignment = HorizontalAlignment.Stretch
        };

        // Spalten für Inhalt + 1 extra für den letzten Button (wenn kein Header)
        int spaltenAnzahl = inhalte.Count + (istHeader ? 0 : 1);

        for (int i = 0; i < spaltenAnzahl; i++)
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            });

            UIElement zelleninhalt;

            // Erster Button (wenn kein Header)
            if (i == 0 && !istHeader)
            {
                var button = new Button
                {
                    Content = inhalte[i],
                    Padding = new Thickness(2),
                    FontSize = 10,
                    MinWidth = 20,
                    MinHeight = 20,
                    Tag = datenzeile,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                button.Click += ZeilenButton_Click;
                zelleninhalt = button;
            }
            // Letzter Button (wenn kein Header)
            else if (i == spaltenAnzahl - 1 && !istHeader)
            {
                var button = new Button
                {
                    Content = "…", // oder "Edit", Symbol etc.
                    Padding = new Thickness(2),
                    FontSize = 10,
                    Tag = datenzeile,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                button.Click += LoeschenButton_Click; // Eigene Methode
                zelleninhalt = button;
            }
            // Normale Textzellen
            else
            {
                // Index anpassen, weil eine zusätzliche Spalte am Ende ist
                string text = i < inhalte.Count ? inhalte[i] : string.Empty;

                zelleninhalt = new TextBlock
                {
                    Text = text,
                    Padding = new Thickness(4),
                    FontWeight = istHeader ? FontWeights.Bold : FontWeights.Normal,
                    TextAlignment = TextAlignment.Right,
                    HorizontalAlignment = HorizontalAlignment.Right,
                    VerticalAlignment = VerticalAlignment.Center,
                    TextTrimming = TextTrimming.CharacterEllipsis
                };
            }

            var border = new Border
            {
                BorderThickness = new Thickness(0.5),
                BorderBrush = new SolidColorBrush(Colors.Gray),
                Child = zelleninhalt
            };

            Grid.SetColumn(border, i);
            grid.Children.Add(border);
        }

        return grid;
    }
    private async void LoeschenButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn && btn.Tag is object datensatz)
        {
            var tabellenName = CBTabelle.SelectedItem as string;
            await LoeschenDynamischAsync(tabellenName, datensatz);
            Debug.WriteLine("Datensatz gelöscht: " + datensatz);
        }
    }
    private void ZeilenButton_Click(object sender, RoutedEventArgs e)
    {
        ElementeAusblenden(EditPanel);
        if (sender is Button btn && btn.Tag is object datensatz)
        {
            EditPanel.Children.Clear(); // Clear vorherige Eingabefelder

            var props = datensatz.GetType().GetProperties();

            foreach (var prop in props)
            {
                // Property-Name als Label
                var label = new TextBlock
                {
                    Text = prop.Name.Replace('_', ' '),
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(0, 5, 0, 2)
                };

                EditPanel.Children.Add(label);

                // Wert holen
                var value = prop.GetValue(datensatz);

                FrameworkElement inputControl;

                // Eingabefeld basierend auf Datentyp
                if (prop.PropertyType == typeof(bool))
                {
                    var cb = new CheckBox
                    {
                        IsChecked = value as bool?,
                        Tag = prop.Name // Optional: Name speichern für spätere Verarbeitung
                    };
                    inputControl = cb;
                }
                else if (prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?))
                {
                    var dp = new DatePicker
                    {
                        SelectedDate = value as DateTime?,
                        Tag = prop.Name
                    };
                    inputControl = dp;
                }
                else
                {
                    // Für alle anderen Datentypen TextBox (inkl. int, double, string usw.)
                    var tb = new TextBox
                    {
                        Text = value?.ToString() ?? "",
                        Tag = prop.Name
                    };
                    inputControl = tb;
                }

                // Optional: Margin für das Eingabefeld
                inputControl.Margin = new Thickness(0, 0, 0, 5);

                EditPanel.Children.Add(inputControl);
            }
        }
    }
    public async Task SpeichereDynamischAsync(string tabellenName, Dictionary<string, object> daten)
    {

        var entityType = typeof(MyDbContext).Assembly
            .GetTypes()
            .FirstOrDefault(t => t.IsClass && t.Namespace == "StammDatenModulData.Models" && t.Name == tabellenName);

        if (entityType == null)
            throw new Exception($"Typ '{tabellenName}' nicht gefunden.");

        var entity = Activator.CreateInstance(entityType);

        foreach (var kvp in daten)
        {
            var prop = entityType.GetProperty(kvp.Key);
            if (prop == null || !prop.CanWrite)
                continue;

            object convertedValue = null;
            if (kvp.Value != null)
            {
                try
                {
                    convertedValue = Convert.ChangeType(kvp.Value, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                catch
                {
                    // Optional: Logge Problem
                    continue;
                }
            }


            prop.SetValue(entity, convertedValue);
        }

        //if (result.Results.Any(r => !r.Passed))
        //{
        //    var fehlerMeldungen = string.Join("\n",
        //        result.Results
        //              .Where(r => !r.Passed)
        //              .Select(r => $"{r.RuleName}: {r.Message}"));

        //    throw new ValidationException($"Validierungsfehler:\n{fehlerMeldungen}");
        //}
        var validator = new GenericValidator(_rules);
        var artikelErrors = validator.Validate(entity);
        if(artikelErrors.Any())
        {
            var fehlerMeldungen = string.Join("\n", artikelErrors);
            throw new ValidationException($"Validierungsfehler:\n{fehlerMeldungen}");
        }
        _context.Add(entity);
        _context.SaveChanges();
    }
    public async Task LoeschenDynamischAsync(string tabellenName, object daten)
    {
        var entityType = typeof(MyDbContext).Assembly
            .GetTypes()
            .FirstOrDefault(t => t.IsClass && t.Namespace == "StammDatenModulData.Models" && t.Name == tabellenName);

        if (entityType == null)
            throw new Exception($"Typ '{tabellenName}' nicht gefunden.");

        // Primärschlüssel-Felder herausfinden
        var entityTypeInfo = _context.Model.FindEntityType(entityType);
        var keyProperties = entityTypeInfo.FindPrimaryKey().Properties;

        // Schlüsselwerte extrahieren
        var keyValues = keyProperties
            .Select(p =>
            {
                var prop = daten.GetType().GetProperty(p.Name);
                if (prop == null)
                    throw new Exception($"Property '{p.Name}' fehlt im Datensatz.");

                return prop.GetValue(daten);
            })
            .ToArray();

        // Objekt aus DB laden
        var entityFromDb = await _context.FindAsync(entityType, keyValues);
        if (entityFromDb == null)
            throw new Exception("Datensatz nicht gefunden.");

        // Löschen
        _context.Remove(entityFromDb);
        await _context.SaveChangesAsync();
    }
    public static object MappeZuEntity(Type entityType, object daten)
    {
        // daten sollte ein Dictionary<string, object> sein
        var entity = Activator.CreateInstance(entityType);
        if (daten is Dictionary<string, object> dict)
        {
            foreach (var kvp in dict)
            {
                var prop = entityType.GetProperty(kvp.Key);
                if (prop != null && prop.CanWrite)
                {
                    object convertedValue = null;
                    if (kvp.Value != null)
                    {
                        try
                        {
                            convertedValue = Convert.ChangeType(kvp.Value, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    prop.SetValue(entity, convertedValue);
                }
            }
        }
        return entity;
    }
}
