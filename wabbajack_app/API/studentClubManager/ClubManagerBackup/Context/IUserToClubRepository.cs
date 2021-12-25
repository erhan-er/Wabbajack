
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
    public interface IUserToClubRepository
    {
        Task Add<T>(T entity) where T : class;
        Task Delete<T>(T entity) where T : class;
    }
}