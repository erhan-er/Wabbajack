using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Interface for EventHandler
   /// </summary>
   public interface IEventHandler
   {
      /// <summary>
      /// Creates event.
      /// </summary>
      /// <param name="newEvent">Event to be created.</param>
      /// <param name="context">Database reference.</param>
      /// <returns></returns>
      Task<Event> CreateEvent(StudentEvent newEvent, DataContext context);
   }
}
