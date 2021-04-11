using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using BookAPI.Controllers;
using Microsoft.IdentityModel.Tokens;

namespace BookAPI.JWT
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {

        private readonly IDictionary<string, string> users = new Dictionary<string, string>
        {{"test1", "password1"}, {"test2", "password2"}};

        private readonly string key;


        public JwtAuthenticationManager(string key)
        {
            this.key = key;
        }

        // checken of username & password  in de Dictionary zit:
        public string Authenticate(string username, string password)
        {
            if (!users.Any(user => user.Key == username && user.Value == password))
            {
                return null;
            }



            //Token creëren
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenKey = Encoding.ASCII.GetBytes(key);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim (ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddHours(2),  // 2uur geldig
                SigningCredentials =
                new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                     SecurityAlgorithms.HmacSha256Signature)

            };
            //Token verkrijgen
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
