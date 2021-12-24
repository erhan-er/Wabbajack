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
   [Route("api/Events")]
   public class EventController : Controller
   {
      private IEventRepository eventRepository;
      private IConfiguration configuration;
      private IMapper mapper;
        private Context.EventHandler eventHandler;
        private DataContext context;

      public EventController(IEventRepository eventRepository, IConfiguration configuration, IMapper mapper, DataContext context)
      {
         this.eventRepository = eventRepository;
         this.configuration = configuration;
            this.context = context;
         this.mapper = mapper;
      }

      [HttpPost("create")]
      public async Task<IActionResult> AddEvent([FromBody] EventDto eventDto)
      {
         if (await eventRepository.EventExists(eventDto.Name))
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
            Cost = eventDto.Cost,
            Capacity = eventDto.Capacity,
            UserID = eventDto.UserId,
            PlaceID = eventDto.PlaceID,
            CategoryID = eventDto.CategoryID,
            Name = eventDto.Name,
            Description = eventDto.Description,
            AdminID = 12,
            IsApproved = true
         };
            eventHandler = new Context.EventHandler(ClubEventCreator.getInstance());
            var createdEvent = await eventHandler.CreateEvent(eventToCreate, context);
            return StatusCode(201);
        }

      [HttpPost("update")]
      public async Task<IActionResult> UpdateEvent([FromBody] EventDto eventDto)
      {
         var eventToUpdate = eventRepository.GetEventByID(eventDto.ID);
         eventToUpdate.Name = eventDto.Name;
         eventToUpdate.Description = eventDto.Description;
         var updatedEvent = await eventRepository.UpdateEvent(eventToUpdate);
         return StatusCode(201);
      }

      [HttpPost("delete")]
      public async Task<IActionResult> DeleteEvent([FromBody] EventDto eventDto)
      {
         var eventToDelete = eventRepository.GetEventByID(eventDto.ID);
         await eventRepository.DeleteEvent(eventToDelete);
         return StatusCode(201);
      }

      [HttpGet]
      public IActionResult GetEvents()
      {
         var events = eventRepository.GetEvents();
         var eventsToReturn = mapper.Map<List<EventDto>>(events);
         return Ok(eventsToReturn);
      }

      [HttpGet("{id}")]
      public IActionResult GetEventByID(int ID)
      {
         var theEvent = eventRepository.GetEventByID(ID);
         var eventsToReturn = mapper.Map<EventDto>(theEvent);
         return Ok(eventsToReturn);
      }


   }
}
