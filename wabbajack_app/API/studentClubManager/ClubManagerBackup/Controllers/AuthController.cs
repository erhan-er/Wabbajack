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
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagerBackup.Controllers
{
   /// <summary>
   /// Controller class for Authentication
   /// </summary>
   [Authorize]
   [Produces("application/json")]
   [Route("api/Auth")]
   public class AuthController : Controller
   {
      private IAuthRepository authRepository;
      private IConfiguration configuration;

      /// <summary>
      /// Constructor for AuthController
      /// </summary>
      /// <param name="authRepository">AuthRepository reference.</param>
      /// <param name="configuration">Configuration reference.</param>
      public AuthController(IAuthRepository authRepository, IConfiguration configuration)
      {
         this.authRepository = authRepository;
         this.configuration = configuration;
      }

      /// <summary>
      /// Registers user to the system.
      /// </summary>
      /// <param name="registerDto">Data transfer object of user to be registered.</param>
      /// <returns></returns>
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

      /// <summary>
      /// Logs in user to the system.
      /// </summary>
      /// <param name="loginDto">Data transfer object of user to be logged in.</param>
      /// <returns></returns>
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

        /// <summary>
        /// Logs in user to the system.
        /// </summary>
        /// <param name="loginDto">Data transfer object of user to be logged in.</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("login/resetpassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changePasswordDto)
        {

            if (!await authRepository.UserExistsWithMail(changePasswordDto.Mail))
            {
                ModelState.AddModelError("Mail", "Mail does not exists!");
            }

            Guid guid = Guid.NewGuid();
            var psswrd = guid.ToString().Substring(0, 8);
            var name = changePasswordDto.Mail.Substring(0, changePasswordDto.Mail.IndexOf('@'));


            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("wabbajackproject@gmail.com");
                    mail.To.Add(changePasswordDto.Mail);
                    mail.Subject = "Password Recovery";
                    mail.Body = string.Format("Hi " + name + ",<br /><br />Your password is " + psswrd + ".<br /><br />Thank You.");
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("wabbajackproject@gmail.com", "123456wabba");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        Console.WriteLine("it is sent furkan");
                        
                    }
                }


            }
            catch
            {
                Console.WriteLine("error occured furkan");
            }

            var user = await authRepository.ChangePassword(changePasswordDto.Mail, psswrd);

            return StatusCode(201);

        }

    }
}
