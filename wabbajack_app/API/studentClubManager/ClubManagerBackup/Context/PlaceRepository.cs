using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClubManagerBackup.Context
{
   public class PlaceRepository : IPlaceRepository
   {
      private DataContext context;

      public PlaceRepository(DataContext context)
      {
         this.context = context;
      }

      /// <summary>
      /// Adds new place to the database. 
      /// </summary>
      /// <param name="newPlace">New place to be added.</param>
      /// <returns>Returns added place.</returns>

      public async Task<Place> AddPlace(Place newPlace)
      {
         await context.Places.AddAsync(newPlace);
         await context.SaveChangesAsync();
         return newPlace;
      }

      /// <summary>
      /// Deletes place from the database.
      /// </summary>
      /// <param name="placeToDelete">Place to be deleted.</param>
      public async Task DeletePlace(Place placeToDelete)
      {
         context.Places.Remove(placeToDelete);
         await context.SaveChangesAsync();
      }

      /// <summary>
      /// Finds a place from the database with given ID.
      /// </summary>
      /// <param name="ID">ID of the searched place.</param>
      /// <returns>Returns the with given ID.</returns>
      public Place GetPlaceByID(int ID)
      {
         var place = context.Places.FirstOrDefault(c => c.ID == ID);
         return place;
      }

      /// <summary>
      /// Gets all places in the database.
      /// </summary>
      /// <returns>Returns list of all places.</returns>
      public List<Place> GetPlaces()
      {
         var places = context.Places.ToList();
         return places;
      }

      /// <summary>
      /// Checks if place with given name exists in the database. 
      /// </summary>
      /// <param name="placeName">Name of the club to be checked.</param>
      /// <returns>Returns true if place exists, else returns false.</returns>
      public async Task<bool> PlaceExists(string placeName)
      {
         if (await context.Places.AnyAsync(x => x.Room == placeName))
         {
            return true;
         }
         return false;
      }
   }
}
