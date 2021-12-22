using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubManagerBackup.Entities;

namespace ClubManagerBackup.Context
{
    public class ClubRepository : IClubRepository
    {
        private DataContext context;

        public ClubRepository(DataContext context)
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

        public Club GetClubById(int id)
        {
            var club = context.Clubs.FirstOrDefault(c => c.ID == id);
            return club;
        }

        public List<Club> GetClubs()
        {
            var clubs = context.Clubs.ToList();
            return clubs;;
        }

        public bool SaveAll<T>(T entity)
        {
            return context.SaveChanges() > 0;
        }
    }
}