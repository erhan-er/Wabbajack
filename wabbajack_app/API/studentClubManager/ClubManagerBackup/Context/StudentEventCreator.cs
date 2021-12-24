using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Singleton class for Student Event Creator
   /// </summary>
   public class StudentEventCreator : IEventHandler
   {
      private static StudentEventCreator instance = null;


      private StudentEventCreator()
      {
      }

      /// <summary>
      /// Gets singleton instance of StudentEventCreator object.
      /// </summary>
      /// <returns>Returns the StudentEventCreator.</returns>
      public static StudentEventCreator getInstance()
      {
         if (instance == null)
         {
            instance = new StudentEventCreator();
         }
         return instance;
      }

      /// <summary>
      /// Creates student event.
      /// </summary>
      /// <param name="studentEvent">Event to be created.</param>
      /// <param name="context">Database to store the event.</param>
      /// <returns></returns>
      public async Task<Event> CreateEvent(StudentEvent studentEvent, DataContext context)
      {
         await context.StudentEvents.AddAsync(studentEvent);
         await context.SaveChangesAsync();
         return studentEvent;
      }
   }
}
