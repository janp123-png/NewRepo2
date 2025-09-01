using System;
using System.Collections.Generic;
using System.Linq;
using StammDatenModul.Config;

namespace StammDatenModulData.Models;

public class ArtikelValidator
{
    public List<string> Validate(ARTIKEL artikel)
    {
        var temo = SecureDecryptHelper.ReadContainerFromFile("notAllowedEntityTypes.geConf");
        var errors = new List<string>();

        if (artikel.FILIALLE_NR <= 0)
            errors.Add("Filialnummer muss größer als 0 sein.");

        if (string.IsNullOrWhiteSpace(artikel.ARTIKEL_NR))
            errors.Add("Artikelnummer darf nicht leer sein.");

        if (string.IsNullOrWhiteSpace(artikel.NAME) && string.IsNullOrWhiteSpace(artikel.BEZEICHNUNG))
            errors.Add("Artikel muss mindestens einen Namen oder eine Bezeichnung haben.");

        if (artikel.BRUTTO_VK < 0)
            errors.Add("Verkaufspreis (Brutto) darf nicht negativ sein.");

        if (artikel.NETTO_EK < 0)
            errors.Add("Einkaufspreis (Netto) darf nicht negativ sein.");

        if (artikel.MWST is < 0 or > 100)
            errors.Add("MwSt muss zwischen 0 und 100 liegen.");

        if (artikel.BESTAND < 0)
            errors.Add("Bestand darf nicht negativ sein.");

        if (!string.IsNullOrWhiteSpace(artikel.PACKUNG_EAN))
        {
            if (!(artikel.PACKUNG_EAN.All(char.IsDigit) &&
                  (artikel.PACKUNG_EAN.Length == 8 || artikel.PACKUNG_EAN.Length == 13)))
            {
                errors.Add("Packung-EAN muss 8- oder 13-stellig und numerisch sein.");
            }
        }

        if (artikel.ANGEBOT_DATUM_VON != null && artikel.ANGEBOT_DATUM_BIS != null)
        {
            if (artikel.ANGEBOT_DATUM_VON > artikel.ANGEBOT_DATUM_BIS)
                errors.Add("Angebotszeitraum ist ungültig (Von-Datum liegt nach Bis-Datum).");
        }

        if (artikel.ANGEBOT_PREIS < 0)
            errors.Add("Angebotspreis darf nicht negativ sein.");

        if (!string.IsNullOrEmpty(artikel.JUGEND_SCHUTZ) && artikel.JUGEND_SCHUTZ.Equals("JA", StringComparison.OrdinalIgnoreCase))
        {
            if (artikel.JUGEND_ALTER == null || artikel.JUGEND_ALTER <= 0)
                errors.Add("Für jugendgeschützte Artikel muss ein Mindestalter angegeben werden.");
        }

        return errors;
    }
}
