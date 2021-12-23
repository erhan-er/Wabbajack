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

      public EventController(IEventRepository eventRepository, IConfiguration configuration, IMapper mapper)
      {
         this.eventRepository = eventRepository;
         this.configuration = configuration;
         this.mapper = mapper;
      }

      [HttpPost("addevent")]
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

         var eventToCreate = new Event
         {
            ClubID = eventDto.ClubID,
            EventCost = eventDto.Cost,
            Capacity = eventDto.Capacity,
            UserID = eventDto.UserId,
            Name = eventDto.Name,
            Description = eventDto.Description
         };
         var createdEvent = await eventRepository.AddEvent(eventToCreate);
         return StatusCode(201);
      }

      [HttpPost("updateevent")]
      public async Task<IActionResult> UpdateEvent([FromBody] EventDto eventDto)
      {
         var eventToUpdate = eventRepository.GetEventByID(eventDto.ID);
         eventToUpdate.Name = eventDto.Name;
         eventToUpdate.Description = eventDto.Description;
         var updatedEvent = await eventRepository.UpdateEvent(eventToUpdate);
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
