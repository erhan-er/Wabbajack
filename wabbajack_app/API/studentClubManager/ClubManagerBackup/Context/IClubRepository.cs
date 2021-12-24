using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubManagerBackup.Entities;

namespace ClubManagerBackup.Context
{
    public interface IClubRepository
    {
        List<Club> GetClubs();
        Club GetClubById(int id);
        Club GetClubByName(string name);
        Task<bool>  ClubExists(string clubName);
        Task<Club> AddClub(Club newClub);
        Task<Club> UpdateClub(Club clubToUpdate);
        Task RemoveClub(Club clubToDelete);

        Task AddMember( User student, string clubName);


    }
}