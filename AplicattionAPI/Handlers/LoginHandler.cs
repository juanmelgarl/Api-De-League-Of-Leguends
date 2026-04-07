using AplicattionAPI.Common;
using AplicattionAPI.DTOS.Request.Comand;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AplicattionAPI.Handlers
{
    public class LoginHandler : IRequestHandler<LoginCommand,Result<string>>
    {
        private readonly IConfiguration _Config;

        public LoginHandler(IConfiguration config)
        {
            _Config = config;
        }
        public async Task<Result<string>> Handle(LoginCommand command, CancellationToken cancellationToken)
        {
            if (command.Username == "admin" && command.Password == "admin")
            {
                var claims = new[]
  {
    new Claim(JwtRegisteredClaimNames.Sub, command.Username),
    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
    new Claim(ClaimTypes.Role, "admin")
};
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Config["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: _Config["Jwt:Issuer"],
                    audience: _Config["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: creds
                );

                var tokenstring = new JwtSecurityTokenHandler().WriteToken(token);
                return Result<string>.Success(tokenstring);
            }

            return Result<string>.Failure("Error");
        }
    }
}
    