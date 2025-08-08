using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StammDatenModul.Utility;
public static class DynamischeDatenbankSuche
{
    public static List<T> Suche<T>(DbContext context, Dictionary<string, object> filter) where T : class
    {
        IQueryable<T> query = context.Set<T>();

        foreach (var eintrag in filter)
        {
            if (eintrag.Value == null)
                continue;

            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, eintrag.Key);

            var propertyType = property.Type;
            var convertedValue = Convert.ChangeType(
                eintrag.Value,
                Nullable.GetUnderlyingType(propertyType) ?? propertyType
            );
            var constant = Expression.Constant(convertedValue, propertyType);

            Expression predicate;

            if (propertyType == typeof(string))
            {
                var method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
                predicate = Expression.Call(property, method!, constant);
            }
            else
            {
                predicate = Expression.Equal(property, constant);
            }

            var lambda = Expression.Lambda<Func<T, bool>>(predicate, parameter);
            query = query.Where(lambda);
        }

        return query.Distinct().ToList();
    }
}
