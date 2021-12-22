using AutoMapper;
using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Helpers
{
   public class AutoMapperProfiles : Profile
   {
      public AutoMapperProfiles()
      {
         CreateMap<User, UserDto>();
         CreateMap<Event, EventDto>();
         CreateMap<Club, ClubDto>();
      }
   }
}
