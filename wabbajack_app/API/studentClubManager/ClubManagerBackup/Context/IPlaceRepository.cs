using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   public interface IPlaceRepository
   {
      Task<Place> AddPlace(Place newPlace);
      Task DeletePlace(Place placeToDelete);
      Task<bool> PlaceExists(string placeName);
      List<Place> GetPlaces();
      Place GetPlaceByID(int ID);
   }
}