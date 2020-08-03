using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using ShipMobile.Data.Models;
using ShipMobile.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Helpers
{
    public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
    {
        public ApplicationUserClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager,
            IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            var roles = await UserManager.GetRolesAsync(user);
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, $"{user.Id}"));
            identity.AddClaim(new Claim(ClaimTypes.Name, $"{user.UserName}"));
            identity.AddClaim(new Claim(ClaimTypes.Role, string.Join(",", roles)));
            identity.AddClaim(new Claim("ProfileName", $"{user.FirstName} {user.LastName}".Trim()));
            return identity;
        }
    }
}