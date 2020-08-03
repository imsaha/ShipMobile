using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShipMobile.Data.Models;

namespace ShipMobile.Data.Configurations
{
    public class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasOne(x => x.Customer).WithMany(x => x.Packages).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Address).WithMany().HasForeignKey(x => x.AddressId);


            builder.Property(x => x.PackageType)
                .HasConversion(new EnumToStringConverter<PackageType>());

            builder.HasIndex(x => x.Token).IsUnique();
        }
    }
}
