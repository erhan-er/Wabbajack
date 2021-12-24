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

      public async Task<Place> AddPlace(Place newPlace)
      {
         await context.Places.AddAsync(newPlace);
         await context.SaveChangesAsync();
         return newPlace;
      }

      public async Task DeletePlace(Place placeToDelete)
      {
         context.Places.Remove(placeToDelete);
         await context.SaveChangesAsync();
      }

      public Place GetPlaceByID(int ID)
      {
         var place = context.Places.FirstOrDefault(c => c.ID == ID);
         return place;
      }

      public List<Place> GetPlaces()
      {
         var places = context.Places.ToList();
         return places;
      }

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
