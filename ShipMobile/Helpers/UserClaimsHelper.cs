using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile
{
    public static class UserClaimsHelper
    {
        public static string GetProfileName(this ClaimsPrincipal claimsPrincipal) => claimsPrincipal.FindFirstValue("ProfileName");
        public static long GetUserId(this ClaimsPrincipal claimsPrincipal)
        {
            if (long.TryParse(claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier), out long userId))
                return userId;
            return 0;
        }

    }
}
