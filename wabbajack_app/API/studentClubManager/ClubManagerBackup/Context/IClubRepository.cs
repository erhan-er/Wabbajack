using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubManagerBackup.Entities;

namespace ClubManagerBackup.Context
{
    public interface IClubRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll<T>(T entity);

        List<Club> GetClubs();

        Club GetClubById(int id);
        Club GetClubByName(string name);
        Task<bool>  ClubExists(string clubName);
        Task<Club> AddClub(Club newClub);
        Task<Club> UpdateClub(Club clubToUpdate);
        Task RemoveClub(Club clubToDelete);

    }
}