using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Interface for EventRepository
   /// </summary>
   public interface IEventRepository
   {
      /// <summary>
      /// Adds new event to the database. 
      /// </summary>
      /// <param name="newEvent">New event to be added.</param>
      /// <returns>Returns added event.</returns>
      Task<Event> AddEvent(Event newEvent);

      /// <summary>
      /// Updates the event data in the database.
      /// </summary>
      /// <param name="eventToUpdate">Event to be updated.</param>
      /// <returns>Returns updated event.</returns>
      Task<Event> UpdateEvent(Event eventToUpdate);

      /// <summary>
      /// Deletes event from the database.
      /// </summary>
      /// <param name="eventToDelete">Event to be deleted.</param>
      Task DeleteEvent(Event eventToDelete);

      /// <summary>
      /// Checks if event with given name exists in the database. 
      /// </summary>
      /// <param name="eventName">Name of the club to be checked.</param>
      /// <returns>Returns true if event exists, else returns false.</returns>
      Task<bool> EventExists(string eventName);

      /// <summary>
      /// Gets all events in the database.
      /// </summary>
      /// <returns>Returns list of all events.</returns>
      List<Event> GetEvents();

      /// <summary>
      /// Finds a event from the database with given ID.
      /// </summary>
      /// <param name="ID">ID of the searched event.</param>
      /// <returns>Returns the with given ID.</returns>
      Event GetEventByID(int ID);
   }
}
