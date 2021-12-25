using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Repository for Authentication
   /// </summary>
   public class AuthRepository : IAuthRepository
   {
      /// <summary>
      /// Database reference.
      /// </summary>
      private DataContext context;

      /// <summary>
      /// Constructor for AuthRepository class.
      /// </summary>
      /// <param name="context">Database reference.</param>
      public AuthRepository(DataContext context)
      {
         this.context = context;
      }

      /// <summary>
      /// Tries to find user with given mail and password in database.
      /// </summary>
      /// <param name="userMail">Entered email adress of user that is trying to log in.</param>
      /// <param name="password">Entered password of user that is trying to log in.</param>
      /// <returns>Returns the user with entered mail and password. Returns null if user does not exists.</returns>
      public async Task<User> Login(string userMail, string password)
      {
         var user = await context.Users.FirstOrDefaultAsync(x => x.Mail == userMail);
         if (user == null)
         {
            return null;
         }

         if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
         {
            return null;
         }

         return user;
      }

      /// <summary>
      /// Checks if entered password of the user is same with user's password in the database.
      /// </summary>
      /// <param name="password">Entered password without encryption in login screen.</param>
      /// <param name="passwordHash">Hashed password of user in the database.</param>
      /// <param name="passwordSalt">Salted password of user in the database.</param>
      /// <returns>Returns true if entered password matches the user's password in the database, else returns false.</returns>
      private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
      {
         using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
         {
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < computedHash.Length; i++)
            {
               if (computedHash[i] != passwordHash[i])
               {
                  return false;
               }
            }
            return true;
         }
      }

      /// <summary>
      /// Register users to the database by hashing their passwords.
      /// </summary>
      /// <param name="user">User that is to be registered.</param>
      /// <param name="password">Password of the user to be registered.</param>
      /// <returns>Returns registered user.</returns>
      public async Task<User> Register(User user, string password)
      {
         byte[] passwordHash, passwordSalt;
         CreatePasswordHash(password, out passwordHash, out passwordSalt);

         user.PasswordHash = passwordHash;
         user.PasswordSalt = passwordSalt;

         await context.Users.AddAsync(user);
         await context.SaveChangesAsync();
         return user;
      }

      /// <summary>
      /// Creates hashed and salted password with given password.
      /// </summary>
      /// <param name="password">Password to be hashed.</param>
      /// <param name="passwordHash">Hashed password.</param>
      /// <param name="passwordSalt">Salted password.</param>
      private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
      {
         using (var hmac = new System.Security.Cryptography.HMACSHA512())
         {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
         }
      }

      /// <summary>
      /// Checks if given user with user name exists in the database.
      /// </summary>
      /// <param name="userName">Username to be checked in the database.</param>
      /// <returns>Returns true if user exists, else return false.</returns>
      public async Task<bool> UserExists(string userName)
      {
         if (await context.Users.AnyAsync(x => x.Name == userName))
         {
            return true;
         }
         return false;
      }

        public async Task<User> ChangePassword(string userMail, string password)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Mail == userMail);

            if (user == null)
            {
                return null;
            }

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            context.Users.Update(user);
            await context.SaveChangesAsync();
            return user;
        }

        /// <summary>
        /// Checks if given user with user name exists in the database.
        /// </summary>
        /// <param name="mail">Mail to be checked in the database.</param>
        /// <returns>Returns true if user exists, else return false.</returns>
        public async Task<bool> UserExistsWithMail(string mail)
        {
            if (await context.Users.AnyAsync(x => x.Mail == mail))
            {
                return true;
            }
            return false;
        }
    }
}
