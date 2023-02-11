using eshop.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IUserService _userService;

        public AccountsController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel userLogin)
        {

            var user = _userService.ValidateUser(userLogin.UserName, userLogin.Password);
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName ),
                    new Claim(ClaimTypes.Role, user.Role)

                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("BU CUMLE COK GIZLI"));
                var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                     issuer: "identity.halkbak.com",
                     audience: "hr.halkbank",
                     claims: claims,
                     notBefore: DateTime.Now,
                     expires: DateTime.Now.AddHours(6),
                     signingCredentials: credential);


                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });

            }

            return BadRequest(new { message = "Kullanıcı adı ya da şifre yanlış! " });




        }


    }
}

