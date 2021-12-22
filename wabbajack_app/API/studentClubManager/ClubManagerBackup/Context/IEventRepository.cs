using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   public interface IEventRepository
   {
      void Add<T>(T entity) where T : class;
      void Delete<T>(T entity) where T : class;
      bool SaveAll<T>(T entity);
      Task<Event> AddEvent(Event newEvent);
      Task<Event> UpdateEvent(Event eventToUpdate);
      Task<bool> EventExists(string eventName);

      List<Event> GetEvents();
      Event GetEventByID(int ID);
   }
}
