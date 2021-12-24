using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClubManagerBackup.Context;
using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ClubManagerBackup.Controllers
{
   [Produces("application/json")]
   [Route("api/Clubs")]
   public class ClubController : Controller
   {
      private IClubRepository clubRepository;
      private IUserRepository userRepository;
      private IMapper mapper;

      public ClubController(IClubRepository clubRepository, IMapper mapper, IUserRepository userRepository)
      {
         this.clubRepository = clubRepository;
         this.userRepository = userRepository;
         this.mapper = mapper;
      }

      /// <summary>
      /// Gets all clubs in the system.
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      public IActionResult GetClubs()
      {
         var clubs = this.clubRepository.GetClubs();
         var clubsToReturn = mapper.Map<List<ClubDto>>(clubs);
         return Ok(clubsToReturn);
      }

      /// <summary>
      /// Gets club with given ID.
      /// </summary>
      /// <param name="ID">ID of club to be searched.</param>
      /// <returns></returns>
      [HttpGet("{id}")]
      public IActionResult GetClubById(int id)
      {
         var club = this.clubRepository.GetClubById(id);
         var clubToReturn = mapper.Map<ClubDto>(club);
         return Ok(clubToReturn);
      }

      /// <summary>
      /// Adds club to the system.
      /// </summary>
      /// <param name="clubDto">Data transfer object of club to be added.</param>
      /// <returns></returns>
      [HttpPost("addClub")]
      public async Task<IActionResult> AddClub([FromBody] ClubDto clubDto)
      {
         if (await clubRepository.ClubExists(clubDto.Name))
         {
            ModelState.AddModelError("Name", "Name already exists");
         }

         if (!ModelState.IsValid)
         {
            return BadRequest(ModelState);
         }

         var clubToCreate = new Club
         {
            Name = clubDto.Name,
            ClubDescription = clubDto.ClubDescription,
            //StudentsClubMembers = clubDto.StudentsClubMembers,
            ClubBudget = clubDto.ClubBudget
         };

         var x = await clubRepository.AddClub(clubToCreate);
         return StatusCode(201);
      }

      /// <summary>
      /// Updates club in the system.
      /// </summary>
      /// <param name="clubDto">Data transfer object of club to be updated.</param>
      /// <returns></returns>
      [HttpPost("updateClub")]
      public async Task<ActionResult> UpdateClub([FromBody] ClubDto clubDto)
      {
         var clubToUpdate = clubRepository.GetClubByName(clubDto.Name);
         clubToUpdate.ClubDescription = clubDto.ClubDescription;
         clubToUpdate.ClubBudget = clubDto.ClubBudget;
         var updatedClub = await clubRepository.UpdateClub(clubToUpdate);
         return StatusCode(201);
      }

      /// <summary>
      /// Deletes club from the system.
      /// </summary>
      /// <param name="clubDto">Data transfer object of club to be deleted.</param>
      /// <returns></returns>
      [HttpPost("deleteClub")]
      public async Task<ActionResult> DeleteClub([FromBody] ClubDto clubDto)
      {
         var clubToDelete = clubRepository.GetClubByName(clubDto.Name);
         await clubRepository.RemoveClub(clubToDelete);
         return StatusCode(201);
      }

      [HttpPost("addMember")]
      public async Task<ActionResult> AddMemberToStudent([FromBody] string clubName, [FromBody] int userId)
      {
         var student = userRepository.GetUserByID(userId);
         await clubRepository.AddMember(student, clubName);
         return StatusCode(201);
      }
   }
}