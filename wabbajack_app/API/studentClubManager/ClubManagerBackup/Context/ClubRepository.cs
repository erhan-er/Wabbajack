using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClubManagerBackup.Context
{
    public class ClubRepository : IClubRepository
    {
        private DataContext context;

        public ClubRepository(DataContext context)
        {
            this.context = context;

        }

        public async Task<Club> AddClub(Club newClub)
        {
            await context.Clubs.AddAsync(newClub);
            await context.SaveChangesAsync();
            return newClub;
        }

        public async Task<bool> ClubExists(string clubName)
        {
            if (await context.Clubs.AnyAsync(x => x.Name == clubName))
            {
                return true;
            }
            return false;
        }

        public Club GetClubById(int id)
        {
            var club = context.Clubs.FirstOrDefault(c => c.ID == id);
            return club;
        }

        public Club GetClubByName(string name)
        {
            var club = context.Clubs.FirstOrDefault(c => c.Name == name);
            return club;
        }

        public List<Club> GetClubs()
        {
            var clubs = context.Clubs.ToList();
            return clubs;;
        }

        public async Task<Club> UpdateClub(Club clubToUpdate)
        {
            context.Clubs.Update(clubToUpdate);
            await context.SaveChangesAsync();
            return clubToUpdate;
        }

        public async Task RemoveClub( Club clubToDelete)
        {
            context.Clubs.Remove(clubToDelete);
            await context.SaveChangesAsync();
        }


    }
}