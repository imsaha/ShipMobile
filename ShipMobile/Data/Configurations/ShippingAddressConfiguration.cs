using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipMobile.Data.Models;

namespace ShipMobile.Data.Configurations
{
    public class ShippingAddressConfiguration : IEntityTypeConfiguration<ShippingAddress>
    {
        public void Configure(EntityTypeBuilder<ShippingAddress> builder)
        {
            builder.OwnsOne(x => x.GeoCoordinate)
               .Property(x => x.Latitude).HasColumnName("Latitude");

            builder.OwnsOne(x => x.GeoCoordinate)
                .Property(x => x.Longitude).HasColumnName("Longitude");
        }
    }
}
