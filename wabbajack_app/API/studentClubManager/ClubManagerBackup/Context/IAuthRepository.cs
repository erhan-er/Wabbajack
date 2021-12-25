using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Interface for AuthRepository
   /// </summary>
   public interface IAuthRepository
   {
      /// <summary>
      /// Register users to the database by hashing their passwords.
      /// </summary>
      /// <param name="user">User that is to be registered.</param>
      /// <param name="password">Password of the user to be registered.</param>
      /// <returns>Returns registered user.</returns>
      Task<User> Register(User user, string password);

      /// <summary>
      /// Tries to find user with given mail and password in database.
      /// </summary>
      /// <param name="userMail">Entered email adress of user that is trying to log in.</param>
      /// <param name="password">Entered password of user that is trying to log in.</param>
      /// <returns>Returns the user with entered mail and password. Returns null if user does not exists.</returns>
      Task<User> Login(string userMail, string password);

      /// <summary>
      /// Checks if given user with user name exists in the database.
      /// </summary>
      /// <param name="userName">Username to be checked in the database.</param>
      /// <returns>Returns true if user exists, else return false.</returns>
      Task<bool> UserExists(string userName);
        Task<bool> UserExistsWithMail(string mail);
        Task<User> ChangePassword(string userMail, string password);
    }
}
