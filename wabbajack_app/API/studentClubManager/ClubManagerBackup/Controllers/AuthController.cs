using ClubManagerBackup.Context;
using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagerBackup.Controllers
{
   [Authorize]
   [Produces("application/json")]
   [Route("api/Auth")]
   public class AuthController : Controller
   {
      private IAuthRepository authRepository;
      private IConfiguration configuration;

      public AuthController(IAuthRepository authRepository, IConfiguration configuration)
      {
         this.authRepository = authRepository;
         this.configuration = configuration;
      }

      [AllowAnonymous]
      [HttpPost("register")]
      public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
      {
         if (await authRepository.UserExists(registerDto.Name))
         {
            ModelState.AddModelError("Name", "Name already exists");
         }

         if (!ModelState.IsValid)
         {
            return BadRequest(ModelState);
         }

         var userToCreate = new User
         {
            Name = registerDto.Name,
            Mail = registerDto.Mail,
            Department = registerDto.Department,
            Discriminator = registerDto.Discriminator
         };

         var createdUser = await authRepository.Register(userToCreate, registerDto.Password);
         return StatusCode(201);
      }

      [AllowAnonymous]
      [HttpPost("login")]
      public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
      {
         var user = await authRepository.Login(loginDto.Mail, loginDto.Password);

         if (user == null)
         {
            return Unauthorized();
         }

         var tokenHandler = new JwtSecurityTokenHandler();
         var key = Encoding.ASCII.GetBytes(configuration.GetSection("AppSettings:Token").Value);

         var tokenDescriptor = new SecurityTokenDescriptor
         {
            Subject = new ClaimsIdentity(new Claim[]
             {
                    new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()),
                    new Claim(ClaimTypes.Email, user.Mail)
             }),
            Expires = DateTime.Now.AddDays(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
         };

         var token = tokenHandler.CreateToken(tokenDescriptor);
         var tokenString = tokenHandler.WriteToken(token);

         return Ok(tokenString);
      }


   }
}
