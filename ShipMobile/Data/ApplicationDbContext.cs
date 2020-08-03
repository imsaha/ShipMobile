using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inflector;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ShipMobile.Data.Configurations;
using ShipMobile.Data.Models;
using ShipMobile.Data.ValueObjects;

namespace ShipMobile.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(AddressConfiguration).Assembly);

            builder.Entity<ApplicationRole>().HasData(
                    new ApplicationRole {
                        Id= 1,
                        Name="Admin",
                        NormalizedName= "ADMIN"
                    },
                    new ApplicationRole
                    {
                        Id = 2,
                        Name = "DeliveryAssociate",
                        NormalizedName = "DELIVERYASSOCIATE"
                    }
                );

            builder.PluralizeTableName();
            
        }
    }
}
