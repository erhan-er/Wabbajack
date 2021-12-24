using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Event Handler for Composite Design Pattern
   /// </summary>
   public class EventHandler
   {
      private IEventHandler eventHandler;

      /// <summary>
      /// Constructor for EventHandler class.
      /// </summary>
      /// <param name="eventHandler">EventHandler interface.</param>
      public EventHandler(IEventHandler eventHandler)
      {
         this.eventHandler = eventHandler;
      }

      /// <summary>
      /// Creates event.
      /// </summary>
      /// <param name="newEvent">Event to be created.</param>
      /// <param name="context">Database reference.</param>
      /// <returns></returns>
      public Task<Event> CreateEvent(StudentEvent newEvent, DataContext context)
      {
         return eventHandler.CreateEvent(newEvent, context);
      }
   }
}
