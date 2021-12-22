using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClubManagerBackup.Context;
using ClubManagerBackup.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ClubManagerBackup.Controllers
{
    [Produces("application/json")]
    [Route("api/Clubs")]
    public class ClubController : Controller
    {
        private IClubRepository clubRepository;
        private IMapper mapper;

        public ClubController( IClubRepository clubRepository, IMapper mapper)
        {
            this.clubRepository = clubRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetClubs()
        {
            var clubs = this.clubRepository.GetClubs();
            var clubsToReturn = mapper.Map<List<ClubDto>>(clubs);
            return Ok(clubsToReturn);
        }

        [HttpGet("{id}")]
        public IActionResult GetClubById(int id)
        {
            var club = this.clubRepository.GetClubById(id);
            var clubToReturn = mapper.Map<ClubDto>(club);
            return Ok(clubToReturn);
        }
    }
}