using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   public class UserToEventRepository : IUserToEventRepository
   {
      private DataContext context;
      public UserToEventRepository(DataContext context)
      {
         this.context = context;
      }
      public async Task Add<T>(T entity) where T : class
      {
         await context.AddAsync(entity);
         await context.SaveChangesAsync();
      }

      public async Task Delete<T>(T entity) where T : class
      {
         context.Remove(entity);
         await context.SaveChangesAsync();
      }

      public List<UserToEvent> GetUserToEvents()
      {
         var userToEvents = context.UserToEvents.ToList();
         return userToEvents;
      }
   }
}