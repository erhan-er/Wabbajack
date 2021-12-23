using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
    public class StudentEventCreator : IEventHandler
    {
        private static StudentEventCreator instance = null;


        private StudentEventCreator()
        {
        }

        public static StudentEventCreator getInstance()
        {
            if (instance == null)
            {
                instance = new StudentEventCreator();
            }
            return instance;
        }

        public async Task<Event> CreateEvent(StudentEvent studentEvent, DataContext context)
        {
            await context.StudentEvents.AddAsync(studentEvent);
            await context.SaveChangesAsync();
            return studentEvent;
        }
    }
}
