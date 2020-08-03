using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShipMobile.Data;
using ShipMobile.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtenstion
    {
        public static IApplicationBuilder InitilizeApplication(this IApplicationBuilder builder)
        {
            using var scope = builder.ApplicationServices.CreateScope();

            var applicationDbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            applicationDbContext.Database.Migrate();

            var configuration = scope.ServiceProvider.GetRequiredService<IConfiguration>();

            var adminEmail = configuration.GetSection("Administrator").GetValue<string>("Email");
            var adminPassword = configuration.GetSection("Administrator").GetValue<string>("Password");
            renderUserAsync(scope, adminEmail, adminPassword).GetAwaiter().GetResult();

            return builder;
        }

        private static async Task renderUserAsync(IServiceScope scope, string adminEmail, string adminPassword)
        {
            if (!(string.IsNullOrEmpty(adminEmail) && string.IsNullOrEmpty(adminPassword)))
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var user = await userManager.FindByEmailAsync(adminEmail);
                if (user == null)
                {
                    user = new ApplicationUser()
                    {
                        Email = adminEmail,
                        UserName = adminEmail,
                        RoleName = "Admin",
                        EmailConfirmed = true,
                    };
                    var identityResult = await userManager.CreateAsync(user, adminPassword);
                    if (identityResult.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, "Admin");
                    }
                    else
                    {
                        throw new InvalidEnumArgumentException(identityResult.ToString());
                    }
                }
            }
        }
    }
}
