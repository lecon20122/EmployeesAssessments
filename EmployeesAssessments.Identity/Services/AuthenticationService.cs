using EmployeesAssessments.Application.Contracts.Identity;
using EmployeesAssessments.Application.Models.Authentication;
using EmployeesAssessments.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmployeesAssessments.Identity.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JWTSettings _jwtSettings;

        public AuthenticationService(UserManager<ApplicationUser> userManager, IOptions<JWTSettings> jwtSettings)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
        }

        public async Task<AuthenticationDTO> AuthenticateAsync(AuthenticationRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user is null) throw new Exception("Invalid Password or Email");

            var result = await _userManager.CheckPasswordAsync(user, request.Password);

            if (!result) throw new Exception("Invalid Password or Email");

            var token = await GenerateToken(user);

            return new AuthenticationDTO
            {
                Id = user.Id.ToString(),
                Email = user.Email,
                UserName = user.UserName,
                Token = token
            };
        }

        public async Task<RegistrationDTO> RegisterAsync(RegistrationRequest request)
        {
            var isUserExists = await _userManager.FindByEmailAsync(request.Email);

            if (isUserExists is not null) throw new Exception("User with this Email Address already exists");

            ApplicationUser user = new ApplicationUser
            {
                Email = request.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded) throw new Exception("Something went wrong");

            var token = await GenerateToken(user);

            return new RegistrationDTO
            {
                Id = user.Id,
                Name = user.FirstName,
                Email = user.Email,
                Token = token
            };
        }

        private async Task<string> GenerateToken(ApplicationUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier , user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var authSignedKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

            var token = new JwtSecurityToken(
                               issuer: _jwtSettings.Issuer,
                               audience: _jwtSettings.Audience,
                               expires: DateTime.Now.AddDays(1),
                               claims: claims,
                               signingCredentials: new SigningCredentials(authSignedKey, SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
