using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Interface for UserRepository
   /// </summary>
   public interface IUserRepository
   {

      /// <summary>
      /// Adds user to the database.
      /// </summary>
      /// <typeparam name="T">Type of object:User.</typeparam>
      /// <param name="entity">User to be added</param>
      void Add<T>(T entity) where T : class;

      /// <summary>
      /// Deletes user from the database.
      /// </summary>
      /// <typeparam name="T">Type of object:User.</typeparam>
      /// <param name="entity">User to be deleted.</param>
      void Delete<T>(T entity) where T : class;

      /// <summary>
      /// Save all changes to the database.
      /// </summary>
      /// <typeparam name="T">Type of object:User.</typeparam>
      /// <param name="entity">Entity to be saved.</param>
      /// <returns>Returns true if successful.</returns>
      bool SaveAll<T>(T entity);

      /// <summary>
      /// Gets all users in the database.
      /// </summary>
      /// <returns>Returns list of all users.</returns>
      List<User> GetUsers();

      /// <summary>
      /// Finds a user from the database with given ID.
      /// </summary>
      /// <param name="ID">ID of the searched user.</param>
      /// <returns>Returns the with given ID.</returns>
      User GetUserByID(int ID);

      /// <summary>
      /// Finds a user from the database with given mail.
      /// </summary>
      /// <param name="mail">Mail of the searched user.</param>
      /// <returns>Returns the with given ID.</returns>
      User GetUserByMail(string mail);
   }
}
