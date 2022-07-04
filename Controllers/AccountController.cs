using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using MVC_2.Models;
using Microsoft.AspNetCore.Cors;
using DBMongo;
using Microsoft.AspNetCore.Authorization;

namespace MVC_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [EnableCors]
    public class AccountController : ControllerBase
    {
        private readonly DBService _context;

        public AccountController(DBService context)
        {
            _context = context;

        }

        // GET: api/Account/Token
        [Route("Token")]
        [HttpPost]
        public IActionResult Token(LoginModel model)
        {
            var identity = GetIdentity(model.Login, model.Password);
            if (identity == null)
            {
                Console.WriteLine("Invalid username or password. " + model.Login + "++" + model.Password);
                return BadRequest(new { errorText = "Invalid username or password. " + model.Login + " " + model.Password });
            }

            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                access_token = encodedJwt,
                username = identity.Name
            };

            return new JsonResult(response);
        }

        [Route("Register")]
        [HttpPost]
        public IActionResult Register(LoginModel model)
        {
            var u = _context.SearchUser(model.Login);
            if (u != null)
            {
                Console.WriteLine("Этот логин занят." + model.Login);
                return BadRequest(new { errorText = model.Login + "  - этот логин занят. " });

            }
            _context.CreateUser(model.Login, model.Password);
            return Token(model);
        }

        [Route("Delete")]
        [HttpDelete]
        [Authorize]
        public IActionResult Delete()
        {
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                _context.DeleteUser(u.Id);
            }
            return Ok();
        }

        private ClaimsIdentity GetIdentity(string login, string password)
        {
            var person = _context.SearchUser(login, password);

            if (person != null)
            {
                // string role = _context.Roles.FirstOrDefault(r => r.Id == person.RoleId).Name;
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.Login),
                //    new Claim(ClaimsIdentity.DefaultRoleClaimType, role)
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            // если пользователя не найдено
            return null;
        }
    }
}
