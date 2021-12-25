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
   /// Controller class for Events.
   /// </summary>
   [Produces("application/json")]
   [Route("api/Events")]
   public class EventController : Controller
   {
      private IEventRepository eventRepository;
      private IClubRepository clubRepository;
      private ICategoryRepository categoryRepository;
      private IPlaceRepository placeRepository;
      private IConfiguration configuration;
      private IMapper mapper;
      private Context.EventHandler eventHandler;
      private DataContext context;

      /// <summary>
      /// Constructor for EventController.
      /// </summary>
      /// <param name="eventRepository">EventRepository reference.</param>
      /// <param name="configuration">Configuration reference.</param>
      /// <param name="mapper">Mapper reference.</param>
      /// <param name="context">Database reference.</param>
      public EventController(IEventRepository eventRepository, IConfiguration configuration, IMapper mapper, DataContext context,
      ICategoryRepository categoryRepository, IClubRepository clubRepository, IPlaceRepository placeRepository)
      {
         this.eventRepository = eventRepository;
         this.clubRepository = clubRepository;
         this.configuration = configuration;
         this.context = context;
         this.placeRepository = placeRepository;
         this.categoryRepository = categoryRepository;
         this.mapper = mapper;
      }

      /// <summary>
      /// Adds event to the system.
      /// </summary>
      /// <param name="eventDto">Data transfer object of event to be added.</param>
      /// <returns></returns>
      [HttpPost("create")]
      public async Task<IActionResult> AddEvent([FromBody] EventDto eventDto)
      {
         if (await eventRepository.EventExists("asfasfaas" + eventDto.Name))
         {
            ModelState.AddModelError("Name", "Name already exists");
         }

         if (!ModelState.IsValid)
         {
            return BadRequest(ModelState);
         }

         var eventToCreate = new StudentEvent
         {
            ClubID = eventDto.ClubID,
            EventCost = eventDto.EventCost,
            Capacity = eventDto.Capacity,
            UserId = eventDto.UserID,
            ClubBoardMemberID = eventDto.ClubBoardMemberID,
            PlaceID = eventDto.PlaceID,
            PlaceName = placeRepository.GetPlaceByID(eventDto.PlaceID).PlaceName,
            Date = eventDto.Date,
            CategoryID = eventDto.CategoryID,
            CategoryName = categoryRepository.GetCategoryByID(eventDto.CategoryID).CategoryName,
            ClubName = clubRepository.GetClubById(eventDto.CategoryID).Name,
            ImageURL = eventDto.ImageURL,
            Name = eventDto.Name,
            Description = eventDto.Description,
            AdminID = 10, // to be changed
            IsApproved = true
         };
         eventHandler = new Context.EventHandler(ClubEventCreator.getInstance());
         var createdEvent = await eventHandler.CreateEvent(eventToCreate, context);
         return StatusCode(201);
      }

      /// <summary>
      /// Updates event in the system.
      /// </summary>
      /// <param name="eventDto">Data transfer object of event to be updated.</param>
      /// <returns></returns>
      [HttpPost("update")]
      public async Task<IActionResult> UpdateEvent([FromBody] EventDto eventDto)
      {
         var eventToUpdate = eventRepository.GetEventByID(eventDto.ID);
         eventToUpdate.Name = eventDto.Name;
         eventToUpdate.Description = eventDto.Description;
         var updatedEvent = await eventRepository.UpdateEvent(eventToUpdate);
         return StatusCode(201);
      }

      /// <summary>
      /// Deletes event from the system.
      /// </summary>
      /// <param name="eventDto">Data transfer object of event to be deleted.</param>
      /// <returns></returns>
      [HttpPost("delete")]
      public async Task<IActionResult> DeleteEvent([FromBody] EventDto eventDto)
      {
         var eventToDelete = eventRepository.GetEventByID(eventDto.ID);
         await eventRepository.DeleteEvent(eventToDelete);
         return StatusCode(201);
      }

      /// <summary>
      /// Gets all events in the system.
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      public IActionResult GetEvents()
      {
         var events = eventRepository.GetEvents();
         var eventsToReturn = mapper.Map<List<EventDto>>(events);
         return Ok(eventsToReturn);
      }

      /// <summary>
      /// Gets event with given ID.
      /// </summary>
      /// <param name="ID">ID of event to be searched.</param>
      /// <returns></returns>
      [HttpGet("{id}")]
      public IActionResult GetEventByID(int ID)
      {
         var theEvent = eventRepository.GetEventByID(ID);
         var eventsToReturn = mapper.Map<EventDto>(theEvent);
         return Ok(eventsToReturn);
      }


   }
}
