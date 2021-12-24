using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   public class ClubEventCreator : IEventHandler
   {
      private static ClubEventCreator instance = null;

      private ClubEventCreator()
      {
      }

      /// <summary>
      /// Gets singleton instance of ClubEventCreator object.
      /// </summary>
      /// <returns>Returns the ClubEventCreator.</returns>
      public static ClubEventCreator getInstance()
      {
         if (instance == null)
         {
            instance = new ClubEventCreator();
         }
         return instance;
      }

      /// <summary>
      /// Creates club event.
      /// </summary>
      /// <param name="newEvent">Event to be created.</param>
      /// <param name="context">Database to store the event.</param>
      /// <returns></returns>
      public async Task<Event> CreateEvent(StudentEvent newEvent, DataContext context)
      {
         await context.Events.AddAsync((Event)newEvent);
         await context.SaveChangesAsync();
         return newEvent;
      }
   }
}
