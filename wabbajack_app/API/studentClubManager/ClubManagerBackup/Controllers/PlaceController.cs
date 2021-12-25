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
   /// <summary>
   /// Controller class for Places
   /// </summary>
   [Produces("application/json")]
   [Route("api/Places")]
   public class PlaceController : Controller
   {
      private IPlaceRepository placeRepository;
      private IConfiguration configuration;
      private IMapper mapper;
      private Context.EventHandler placeHandler;
      private DataContext context;

      /// <summary>
      /// Constructor for EventController.
      /// </summary>
      /// <param name="placeRepository">PlaceRepository reference.</param>
      /// <param name="configuration">Configuration reference.</param>
      /// <param name="mapper">Mapper reference.</param>
      /// <param name="context">Database reference.</param>
      public PlaceController(IPlaceRepository placeRepository, IConfiguration configuration, IMapper mapper, DataContext context)
      {
         this.placeRepository = placeRepository;
         this.configuration = configuration;
         this.context = context;
         this.mapper = mapper;
      }

      /// <summary>
      /// Adds place to the system.
      /// </summary>
      /// <param name="placeDto">Data transfer object of place to be added.</param>
      /// <returns></returns>
      [HttpPost("add")]
      public async Task<IActionResult> AddPlace([FromBody] PlaceDto placeDto)
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
            PlaceName = placeDto.Building + "-" + placeDto.Room

         };
         var createdPlace = await placeRepository.AddPlace(placeToCreate);
         return StatusCode(201);
      }

      /// <summary>
      /// Deletes place from the system.
      /// </summary>
      /// <param name="placeDto">Data transfer object of place to be deleted.</param>
      /// <returns></returns>
      [HttpPost("delete")]
      public async Task<IActionResult> DeletePlace([FromBody] PlaceDto placeDto)
      {
         var placeToDelete = placeRepository.GetPlaceByID(placeDto.ID);
         await placeRepository.DeletePlace(placeToDelete);
         return StatusCode(201);
      }

      /// <summary>
      /// Gets all places in the system.
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      public IActionResult GetPlaces()
      {
         var places = placeRepository.GetPlaces();
         var placesToReturn = mapper.Map<List<PlaceDto>>(places);
         return Ok(placesToReturn);
      }

      /// <summary>
      /// Gets place with given ID.
      /// </summary>
      /// <param name="ID">ID of place to be searched.</param>
      /// <returns></returns>
      [HttpGet("{id}")]
      public IActionResult GetPlaceByID(int ID)
      {
         var place = placeRepository.GetPlaceByID(ID);
         var placeToReturn = mapper.Map<PlaceDto>(place);
         return Ok(placeToReturn);
      }


   }
}
