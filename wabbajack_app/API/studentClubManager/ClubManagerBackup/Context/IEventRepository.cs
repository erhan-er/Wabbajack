using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   public interface IEventRepository
   {
      Task<Event> AddEvent(Event newEvent);
      Task<Event> UpdateEvent(Event eventToUpdate);
      Task DeleteEvent(Event evetToDelete);
      Task<bool> EventExists(string eventName);
      List<Event> GetEvents();
      Event GetEventByID(int ID);
   }
}
