using DBMongo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MVC_2.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace MVC_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [EnableCors]
    public class AccountController : ControllerBase
    {
        private readonly UserDBService _context;

        public AccountController(UserDBService context)
        {
            _context = context;
        }

        // GET: api/Account/Token
        /// <summary>
        /// авторизация пользователя и получение JWTтокена
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("Token")]
        [HttpPost]
        public IActionResult Token(LoginModel model)
        {
            var identity = GetIdentity(model.Email, model.Password);
            if (identity == null)
            {
                Console.WriteLine("Invalid username or password. " + model.Email + "++" + model.Password);
                return BadRequest(new { errorText = "Invalid username or password. " + model.Email + " " + model.Password });
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

        //api/Account/Register
        /// <summary>
        /// регистрация пользователя
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("Register")]
        [HttpPost]
        public IActionResult Register(LoginModel model)
        {
            var u = _context.SearchUser(model.Email);
            if (u != null)
            {
                Console.WriteLine("Этот логин занят." + model.Email);
                return BadRequest(new { errorText = model.Email + "  - этот логин занят. " });

            }
            _context.CreateUser(model.Email, model.Password);
            return Token(model);
        }

        /// <summary>
        /// -удаление текущего пользователя
        /// </summary>
        /// <returns></returns>
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

        private ClaimsIdentity GetIdentity(string email, string password)
        {
            var person = _context.SearchUser(email, password);

            if (person != null)
            {
                // string role = _context.Roles.FirstOrDefault(r => r.Id == person.RoleId).Name;
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.Email),
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
