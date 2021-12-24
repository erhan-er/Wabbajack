using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   public class EventRepository : IEventRepository
   {
      private DataContext context;

      public EventRepository(DataContext context)
      {
         this.context = context;
      }

      /// <summary>
      /// Adds new event to the database. 
      /// </summary>
      /// <param name="newEvent">New event to be added.</param>
      /// <returns>Returns added event.</returns>
      public async Task<Event> AddEvent(Event newEvent)
      {
         await context.Events.AddAsync(newEvent);
         await context.SaveChangesAsync();
         return newEvent;
      }

      /// <summary>
      /// Deletes event from the database.
      /// </summary>
      /// <param name="eventToDelete">Event to be deleted.</param>
      public async Task DeleteEvent(Event eventToDelete)
      {
         context.Events.Remove(eventToDelete);
         await context.SaveChangesAsync();
      }

      /// <summary>
      /// Updates the event data in the database.
      /// </summary>
      /// <param name="eventToUpdate">Event to be updated.</param>
      /// <returns>Returns updated event.</returns>
      public async Task<Event> UpdateEvent(Event eventToUpdate)
      {
         context.Events.Update(eventToUpdate);
         await context.SaveChangesAsync();
         return eventToUpdate;
      }

      /// <summary>
      /// Finds a event from the database with given ID.
      /// </summary>
      /// <param name="ID">ID of the searched event.</param>
      /// <returns>Returns the with given ID.</returns>
      public Event GetEventByID(int ID)
      {
         var theEvent = context.Events.FirstOrDefault(c => c.ID == ID);
         return theEvent;
      }

      /// <summary>
      /// Gets all events in the database.
      /// </summary>
      /// <returns>Returns list of all events.</returns>
      public List<Event> GetEvents()
      {
         var events = context.Events.ToList();
         return events;
      }

      /// <summary>
      /// Checks if event with given name exists in the database. 
      /// </summary>
      /// <param name="name">Name of the club to be checked.</param>
      /// <returns>Returns true if event exists, else returns false.</returns>
      public async Task<bool> EventExists(string name)
      {
         if (await context.Events.AnyAsync(x => x.Name == name))
         {
            return true;
         }
         return false;
      }
   }
}
