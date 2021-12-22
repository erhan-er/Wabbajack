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

      public async Task<Event> AddEvent(Event newEvent)
      {
         await context.Events.AddAsync(newEvent);
         await context.SaveChangesAsync();
         return newEvent;
      }
      public void Add<T>(T entity) where T : class
      {
         context.Add(entity);
      }

      public void Delete<T>(T entity) where T : class
      {
         context.Remove(entity);
      }

      public Event GetEventByID(int ID)
      {
         var theEvent = context.Events.FirstOrDefault(c => c.ID == ID);
         return theEvent;
      }

      public List<Event> GetEvents()
      {
         var events = context.Events.ToList();
         return events;
      }

      public bool SaveAll<T>(T entity)
      {
         return context.SaveChanges() > 0;
      }

      public async Task<bool> EventExists(string userName)
      {
         if (await context.Events.AnyAsync(x => x.Name == userName))
         {
            return true;
         }
         return false;
      }
   }
}
