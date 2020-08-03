using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipMobile.Data.Models;

namespace ShipMobile.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasOne(x => x.Mobile).WithMany().HasForeignKey(x => x.MobileId);
            builder.HasOne(x => x.Email).WithMany().HasForeignKey(x => x.EmailId);
        }
    }
}
