using AutoMapper;
using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Helpers
{
   /// <summary>
   /// Maps similar classes automatically.
   /// </summary>
   public class AutoMapperProfiles : Profile
   {
      /// <summary>
      /// Constructor of AutoMapperProfile.
      /// </summary>
      public AutoMapperProfiles()
      {
         CreateMap<User, UserDto>();
         CreateMap<Event, EventDto>();
         CreateMap<Club, ClubDto>();
         CreateMap<Place, PlaceDto>();
         CreateMap<Category, CategoryDto>();
      }
   }
}
