using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipMobile.Data.Models;

namespace ShipMobile.Data.Configurations
{
    //public class ShipmentPackageConfiguraation : IEntityTypeConfiguration<ShipmentPackage>
    //{
    //    public void Configure(EntityTypeBuilder<ShipmentPackage> builder)
    //    {

    //        builder.HasKey(x => new
    //        {
    //            x.ShipmentId,
    //            x.PackageId
    //        });

    //        builder.HasOne(x => x.Shipment).WithMany(x => x.Packages).HasForeignKey(x => x.ShipmentId);
    //        builder.HasOne(x => x.Package).WithMany().HasForeignKey(x => x.PackageId);
    //    }
    //}
}
