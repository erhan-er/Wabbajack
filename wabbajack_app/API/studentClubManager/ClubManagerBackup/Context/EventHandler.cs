using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
    public class EventHandler
    {
        private IEventHandler eventHandler;

        public EventHandler(IEventHandler eventHandler)
        {
            this.eventHandler = eventHandler;
        }


        public Task<Event> CreateEvent(StudentEvent newEvent, DataContext context)
        {
            return eventHandler.CreateEvent(newEvent, context);
        }
    }
}
