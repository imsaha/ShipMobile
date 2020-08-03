using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ShipMobile.Data.Models;
using ShipMobile.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Controllers
{
    public class AccountController : BaseAPIController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration configuration;

        public AccountController(
            IUnitOfWork unitOfWork,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration
            ) : base(unitOfWork)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }



        [HttpPost, Route("login")]
        public async Task<IActionResult> LoginAsync(LoginRequest request)
        {
            var user = await userManager.FindByEmailAsync(request.Email);
            if (user == null)
                return Unauthorized("Invalid username or password");

            var result = await signInManager.PasswordSignInAsync(user, request.Password, false, false);
            if (!result.Succeeded)
                return Unauthorized("Invalid username or password");

            var roles = await userManager.GetRolesAsync(user);

            var jwtConfiguration = configuration.GetSection("JWT").Get<JwtConfigurationProvider>();

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfiguration.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>();
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("n")));
            claims.Add(new Claim(JwtRegisteredClaimNames.Iss, jwtConfiguration.Issuer));
            claims.Add(new Claim(JwtRegisteredClaimNames.Aud, jwtConfiguration.Audiance));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.Role, string.Join(",", roles)));


            var expiry = DateTime.Now.AddMonths(1);
            var token = new JwtSecurityToken(jwtConfiguration.Issuer,
                            jwtConfiguration.Audiance,
                            claims,
                            expires: expiry,
                            signingCredentials: credentials);
            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new
            {
                token = jwt_token,
                expiry = expiry,
                name = $"{user.FirstName} {user.LastName}".Trim()
            });
        }
    }

    public class JwtConfigurationProvider
    {
        public string Issuer { get; set; }
        public string Audiance { get; set; }
        public string Key { get; set; }
    }


    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
