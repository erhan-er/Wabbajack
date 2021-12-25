using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Repository for Users
   /// </summary>
   public class UserRepository : IUserRepository
   {
      private DataContext context;

      /// <summary>
      /// Constructor for UserRepository class
      /// </summary>
      /// <param name="context"></param>
      public UserRepository(DataContext context)
      {
         this.context = context;
      }


      /// <summary>
      /// Adds user to the database.
      /// </summary>
      /// <typeparam name="T">Type of object:User.</typeparam>
      /// <param name="entity">User to be added</param>
      public void Add<T>(T entity) where T : class
      {
         context.Add(entity);
      }

      /// <summary>
      /// Deletes user from the database.
      /// </summary>
      /// <typeparam name="T">Type of object:User.</typeparam>
      /// <param name="entity">User to be deleted.</param>
      public void Delete<T>(T entity) where T : class
      {
         context.Remove(entity);
      }

      /// <summary>
      /// Finds a user from the database with given ID.
      /// </summary>
      /// <param name="ID">ID of the searched user.</param>
      /// <returns>Returns the with given ID.</returns>
      public User GetUserByID(int ID)
      {
         var user = context.Users.FirstOrDefault(c => c.ID == ID);
         return user;
      }

      /// <summary>
      /// Finds a user from the database with given mail.
      /// </summary>
      /// <param name="mail">Mail of the searched user.</param>
      /// <returns>Returns the with given ID.</returns>
      public User GetUserByMail(string mail)
      {
         var user = context.Users.FirstOrDefault(c => c.Mail == mail);
         return user;
      }

      /// <summary>
      /// Gets all users in the database.
      /// </summary>
      /// <returns>Returns list of all users.</returns>
      public List<User> GetUsers()
      {
         var users = context.Users.ToList();
         return users;
      }

      /// <summary>
      /// Save all changes to the database.
      /// </summary>
      /// <typeparam name="T">Type of object:User.</typeparam>
      /// <param name="entity">Entity to be saved.</param>
      /// <returns>Returns true if successful.</returns>
      public bool SaveAll<T>(T entity)
      {
         return context.SaveChanges() > 0;
      }
      /// <summary>
      /// Deletes user from the database.
      /// </summary>
      /// <param name="userToDelete">User to be deleted.</param>
      public async Task DeleteUser(User userToDelete)
      {
         context.Users.Remove(userToDelete);
         await context.SaveChangesAsync();
      }

        public async Task<User> ChangePassword(string userMail, string password)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Mail == userMail);

            if (user == null)
            {
                return null;
            }

            byte[] passwordHash, passwordSalt;
            AuthRepository.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            context.Users.Update(user);
            await context.SaveChangesAsync();
            return user;
        }
    }
}
