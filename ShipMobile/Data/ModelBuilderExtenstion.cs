using ShipMobile.Data.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.EntityFrameworkCore
{
    public static class ModelBuilderExtenstion
    {
        public static void PluralizeTableName(this ModelBuilder modelBuilder)
        {
            var inflector = new Inflector.Inflector(new System.Globalization.CultureInfo("en-US"));
            var models = modelBuilder.Model.GetEntityTypes().Where(s => !typeof(ValueObject).IsAssignableFrom(s.ClrType)).ToList();
            foreach (var item in models)
            {
                string tableName = inflector.Pluralize(item.GetTableName()) ?? item.Name;
                item.SetTableName(tableName);
            }
        }
    }
}
