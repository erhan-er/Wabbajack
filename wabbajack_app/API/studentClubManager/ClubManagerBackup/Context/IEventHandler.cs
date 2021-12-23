using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
    public interface IEventHandler
    {
        Task<Event> CreateEvent(StudentEvent newEvent, DataContext context);
    }
}
