using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
    public class UserRepository : IUserRepository
    {
        private DataContext context;

        public UserRepository(DataContext context)
        {
            this.context = context;
        }


        public void Add<T>(T entity) where T : class
        {
            context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            context.Remove(entity);
        }

        public User GetUserByID(int ID)
        {
            var user = context.Users.FirstOrDefault(c => c.ID == ID);
            return user;
        }

        public List<User> GetUsers()
        {
            var users = context.Users.ToList();
            return users;
        }

        public bool SaveAll<T>(T entity)
        {
            return context.SaveChanges() > 0;
        }
    }
}
