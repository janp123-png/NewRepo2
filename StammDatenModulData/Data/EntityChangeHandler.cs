using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StammDatenModulData.Models;

namespace StammDatenModulData.Data;
public static class EntityChangeHandler
{
    public static void HandleEntityChange(EntityEntry entry, MyDbContext context)
    {
        var entity = entry.Entity;

        //switch (entity)
        //{
        //    case Produkt produkt:
        //        context.Set<AuditLog>().Add(new AuditLog
        //        {
        //            Aktion = "Produkt erstellt",
        //            Zeitstempel = DateTime.Now,
        //            Details = produkt.Name
        //        });
        //        break;

        //    case Kunde kunde:
        //        context.Set<AuditLog>().Add(new AuditLog
        //        {
        //            Aktion = "Neuer Kunde",
        //            Zeitstempel = DateTime.Now,
        //            Details = kunde.Vorname + " " + kunde.Nachname
        //        });
        //        break;

        //        // Weitere Typen prüfen ...
        //}
    }
}
