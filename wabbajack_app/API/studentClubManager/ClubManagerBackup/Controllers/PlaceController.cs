using ClubManagerBackup.Context;
using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagerBackup.Controllers
{
   [Produces("application/json")]
   [Route("api/Places")]
   public class PlaceController : Controller
   {
      private IPlaceRepository placeRepository;
      private IConfiguration configuration;
      private IMapper mapper;
      private Context.EventHandler eventHandler;
      private DataContext context;

      public PlaceController(IPlaceRepository placeRepository, IConfiguration configuration, IMapper mapper, DataContext context)
      {
         this.placeRepository = placeRepository;
         this.configuration = configuration;
         this.context = context;
         this.mapper = mapper;
      }

      [HttpPost("add")]
      public async Task<IActionResult> AddEvent([FromBody] PlaceDto placeDto)
      {
         if (await placeRepository.PlaceExists(placeDto.Room))
         {
            ModelState.AddModelError("Name", "Name already exists");
         }

         if (!ModelState.IsValid)
         {
            return BadRequest(ModelState);
         }

         var placeToCreate = new Place
         {
            Room = placeDto.Room,
            Building = placeDto.Building,
         };
         var createdEvent = await placeRepository.AddPlace(placeToCreate);
         return StatusCode(201);
      }


      [HttpPost("delete")]
      public async Task<IActionResult> DeleteEvent([FromBody] PlaceDto placeDto)
      {
         var placeToDelete = placeRepository.GetPlaceByID(placeDto.ID);
         await placeRepository.DeletePlace(placeToDelete);
         return StatusCode(201);
      }

      [HttpGet]
      public IActionResult GetEvents()
      {
         var places = placeRepository.GetPlaces();
         var placesToReturn = mapper.Map<List<PlaceDto>>(places);
         return Ok(placesToReturn);
      }

      [HttpGet("{id}")]
      public IActionResult GetEventByID(int ID)
      {
         var place = placeRepository.GetPlaceByID(ID);
         var placeToReturn = mapper.Map<PlaceDto>(place);
         return Ok(placeToReturn);
      }


   }
}
