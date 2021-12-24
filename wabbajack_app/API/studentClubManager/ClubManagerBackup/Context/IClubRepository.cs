using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubManagerBackup.Entities;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Interface for ClubRepository
   /// </summary>
   public interface IClubRepository
   {
      /// <summary>
      /// Gets all clubs from the database.
      /// </summary>
      /// <returns>Returns the list of all clubs.</returns>
      List<Club> GetClubs();

      /// <summary>
      /// Finds a club from the databse with given ID.
      /// </summary>
      /// <param name="id">ID of the searched club.</param>
      /// <returns>Returns the club with given ID.</returns>
      Club GetClubById(int id);

      /// <summary>
      /// Finds a club from the database with given name.
      /// </summary>
      /// <param name="name">Name of the searched club.</param>
      /// <returns>Returns the with given name.</returns>
      Club GetClubByName(string name);

      /// <summary>
      /// Checks if the club with given club name is exists in the database.
      /// </summary>
      /// <param name="clubName">Club name to be checked.</param>
      /// <returns>Returns true if club exists, else return false.</returns>
      Task<bool> ClubExists(string clubName);

      /// <summary>
      /// Adds new club to the database.
      /// </summary>
      /// <param name="newClub">New club to be added.</param>
      /// <returns>Returns added club.</returns>
      Task<Club> AddClub(Club newClub);

      /// <summary>
      /// Updates the club data in the database.
      /// </summary>
      /// <param name="clubToUpdate">Club to be updated.</param>
      /// <returns>Returns updated club.</returns>
      Task<Club> UpdateClub(Club clubToUpdate);

      /// <summary>
      /// Removes club from the database.
      /// </summary>
      /// <param name="clubToDelete">Club to be deleted.</param>
      /// <returns></returns>
      Task RemoveClub(Club clubToDelete);

   }
}