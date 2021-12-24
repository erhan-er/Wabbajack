using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Interface for PlaceRepository
   /// </summary>
   public interface IPlaceRepository
   {
      /// <summary>
      /// Adds new place to the database. 
      /// </summary>
      /// <param name="newPlace">New place to be added.</param>
      /// <returns>Returns added place.</returns>
      Task<Place> AddPlace(Place newPlace);

      /// <summary>
      /// Deletes place from the database.
      /// </summary>
      /// <param name="placeToDelete">Place to be deleted.</param>
      Task DeletePlace(Place placeToDelete);

      /// <summary>
      /// Checks if place with given name exists in the database. 
      /// </summary>
      /// <param name="placeName">Name of the club to be checked.</param>
      /// <returns>Returns true if place exists, else returns false.</returns>
      Task<bool> PlaceExists(string placeName);

      /// <summary>
      /// Gets all places in the database.
      /// </summary>
      /// <returns>Returns list of all places.</returns>
      List<Place> GetPlaces();

      /// <summary>
      /// Finds a place from the database with given ID.
      /// </summary>
      /// <param name="ID">ID of the searched place.</param>
      /// <returns>Returns the with given ID.</returns>
      Place GetPlaceByID(int ID);
   }
}