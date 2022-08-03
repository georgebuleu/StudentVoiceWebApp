using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudentVoice.Business.Models;
using StudentVoice.Business.Services.IService;
using StudentVoice.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentVoice.Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
                
        }
        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] UserLoginModel user)
        {

            if (user == null)
                return BadRequest("Invalid Request");

            try
            {
                if (user.Email.Equals(_userService.GetById(_userService.GetByEmail(user.Email)).Email)
                    && user.Password.Equals(_userService.GetById(_userService.GetByEmail(user.Email)).Password))
                {

                    Console.WriteLine(_userService.GetById(_userService.GetByEmail(user.Email)));
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("VERY_SECURE_AND_UNBREAKEABLE_KEY"));
                    var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                    var tokenOptions = new JwtSecurityToken(
                        issuer: "http://localhost:44389",
                        audience: "http://localhost:44389",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(10),
                        signingCredentials: signingCredentials
                        );
                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                    return Ok(new AuthenticatedResponse{ Token = tokenString });

                }
                Console.WriteLine(_userService.GetById(_userService.GetByEmail(user.Email)));
                return Unauthorized();
                
            }
            catch (NullReferenceException)
            {
                return BadRequest("Not a valid email or password: ");
            }
        }



    }
}
