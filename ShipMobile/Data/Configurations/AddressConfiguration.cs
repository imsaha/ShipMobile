using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipMobile.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.OwnsOne(x => x.GeoCoordinate)
                .Property(x => x.Latitude).HasColumnName("Latitude");

            builder.OwnsOne(x => x.GeoCoordinate)
                .Property(x => x.Longitude).HasColumnName("Longitude");

            builder.HasOne(x => x.Mobile).WithMany().HasForeignKey(x => x.MobileId);

        }
    }
}
