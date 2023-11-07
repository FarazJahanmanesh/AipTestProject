
using Microsoft.IdentityModel.Tokens;
using Services.Contracts;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Services.Helper
{
    public class JwtService: IJwtService
    {
        public async Task<string> Generate(Entities.User user)
        {
            var securityKey = Encoding.UTF8.GetBytes("12345678910111213141516"); //should be more than 16 char
            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(securityKey),SecurityAlgorithms.HmacSha256Signature);

            var claims = await GetClaims(user);

            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = "MyWeb",
                Audience = "MyWeb",
                IssuedAt = DateTime.Now,
                NotBefore = DateTime.Now,
                Expires = DateTime.Now.AddHours(1).AddMinutes(30),
                SigningCredentials = signingCredentials,
                Subject = new ClaimsIdentity(claims)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(descriptor);
            var token = tokenHandler.WriteToken(securityToken);
            return token;
        }
        private async Task<IEnumerable<Claim>> GetClaims(Entities.User user)
        {
            var list = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            };
            return list;
        }
    }
}
