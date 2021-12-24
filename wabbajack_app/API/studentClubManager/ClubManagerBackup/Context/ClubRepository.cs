using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Repository for Clubs
   /// </summary>
   public class ClubRepository : IClubRepository
   {
      /// <summary>
      /// Database reference.
      /// </summary>
      private DataContext context;

      /// <summary>
      /// Constructor for ClubRepository.
      /// </summary>
      /// <param name="context"></param>
      public ClubRepository(DataContext context)
      {
         this.context = context;

      }

      /// <summary>
      /// Adds new club to the database.
      /// </summary>
      /// <param name="newClub">New club to be added.</param>
      /// <returns>Returns added club.</returns>
      public async Task<Club> AddClub(Club newClub)
      {
         await context.Clubs.AddAsync(newClub);
         await context.SaveChangesAsync();
         return newClub;
      }

      /// <summary>
      /// Checks if the club with given club name is exists in the database.
      /// </summary>
      /// <param name="clubName">Club name to be checked.</param>
      /// <returns>Returns true if club exists, else return false.</returns>
      public async Task<bool> ClubExists(string clubName)
      {
         if (await context.Clubs.AnyAsync(x => x.Name == clubName))
         {
            return true;
         }
         return false;
      }

      /// <summary>
      /// Finds a club from the databse with given ID.
      /// </summary>
      /// <param name="id">ID of the searched club.</param>
      /// <returns>Returns the club with given ID.</returns>
      public Club GetClubById(int id)
      {
         var club = context.Clubs.FirstOrDefault(c => c.ID == id);
         return club;
      }

      /// <summary>
      /// Finds a club from the database with given name.
      /// </summary>
      /// <param name="name">Name of the searched club.</param>
      /// <returns>Returns the with given name.</returns>
      public Club GetClubByName(string name)
      {
         var club = context.Clubs.FirstOrDefault(c => c.Name == name);
         return club;
      }


      /// <summary>
      /// Gets all clubs from the database.
      /// </summary>
      /// <returns>Returns the list of all clubs.</returns>
      public List<Club> GetClubs()
      {
         var clubs = context.Clubs.ToList();
         return clubs; ;
      }

      /// <summary>
      /// Updates the club data in the database.
      /// </summary>
      /// <param name="clubToUpdate">Club to be updated.</param>
      /// <returns>Returns updated club.</returns>
      public async Task<Club> UpdateClub(Club clubToUpdate)
      {
         context.Clubs.Update(clubToUpdate);
         await context.SaveChangesAsync();
         return clubToUpdate;
      }

      public async Task AddMember(User student, string clubName)
      {
         var currentClub = await context.Clubs.FirstOrDefaultAsync(c => c.Name == clubName);
         currentClub.StudentsClubMembers.Add(student);
         await context.SaveChangesAsync();
      }

      /// <summary>
      /// Removes club from the database.
      /// </summary>
      /// <param name="clubToDelete">Club to be deleted.</param>
      /// <returns></returns>
      public async Task RemoveClub(Club clubToDelete)
      {
         context.Clubs.Remove(clubToDelete);
         await context.SaveChangesAsync();
      }


   }
}