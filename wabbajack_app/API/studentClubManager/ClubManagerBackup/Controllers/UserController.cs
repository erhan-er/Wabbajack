using AutoMapper;
using ClubManagerBackup.Context;
using ClubManagerBackup.Dtos;
using ClubManagerBackup.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UserController : Controller
    {
        private IUserRepository userRepository;
        private IEventRepository eventRepository;
        private IMapper mapper;
        private Context.EventHandler eventHandler;
        private DataContext context;

        public UserController(IUserRepository userRepository, IMapper mapper, IEventRepository eventRepository, DataContext context)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.eventRepository = eventRepository;
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = userRepository.GetUsers();
            var usersToReturn = mapper.Map<List<UserDto>>(users);
            return Ok(usersToReturn);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserByID(int ID)
        {
            var user = userRepository.GetUserByID(ID);
            var userToReturn = mapper.Map<UserDto>(user);
            return Ok(userToReturn);
        }


        [HttpPost("create")]
        public async Task<IActionResult> AddEvent([FromBody] StudentEventDto eventDto)
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
                EventCost = eventDto.Cost,
                Capacity = eventDto.Capacity,
                UserID = eventDto.UserID,
                Name = eventDto.Name,
                Description = eventDto.Description,
                IsApproved = eventDto.IsApproved,
                AdminID = 12, // to be changed
                ClubID = 10
            };
            eventHandler = new Context.EventHandler(StudentEventCreator.getInstance());
            var createdEvent = await eventHandler.CreateEvent(eventToCreate, context);
            return StatusCode(201);
        }


    }
}
