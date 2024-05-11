using MBS.Application.Service;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace MBS.Infrastructure.Service
{
    public class TokenService : ITokenService
    {

        public readonly IConfiguration configuration;
        public TokenService(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public async Task<string> GetJwtToken(List<Claim> claims)
        {
            var tokenHeandeler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(configuration["Jwt:Key"]);
            var tokenDiscriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Issuer = configuration["Jwt:Issuer"],
                Audience = configuration["Jwt:Audience"],
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHeandeler.CreateToken(tokenDiscriptor);
            return tokenHeandeler.WriteToken(token);
        }

    }
}
