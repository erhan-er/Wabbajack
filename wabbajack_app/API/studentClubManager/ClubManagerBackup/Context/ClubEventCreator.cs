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

        public static ClubEventCreator getInstance()
        {
            if (instance == null)
            {
                instance = new ClubEventCreator();
            }
            return instance;
        }

        public async Task<Event> CreateEvent(StudentEvent newEvent, DataContext context)
        {
            await context.Events.AddAsync((Event)newEvent);
            await context.SaveChangesAsync();
            return newEvent;
        }
    }
}
