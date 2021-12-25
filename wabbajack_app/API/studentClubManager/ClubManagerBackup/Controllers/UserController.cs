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
   /// <summary>
   /// Controller class for Users
   /// </summary>
   [Produces("application/json")]
   [Route("api/Users")]
   public class UserController : Controller
   {
      private IUserRepository userRepository;
      private IEventRepository eventRepository;
      private IUserToClubRepository userToClubRepository;
      private IMapper mapper;
      private Context.EventHandler eventHandler;
      private DataContext context;

      /// <summary>
      /// Constructor for EventController.
      /// </summary>
      /// <param name="userRepository">UserRepository reference.</param>
      /// <param name="eventRepository">EventRepository reference.</param>
      /// <param name="mapper">Mapper reference.</param>
      /// <param name="context">Database reference.</param>
      public UserController(IUserRepository userRepository, IMapper mapper, IEventRepository eventRepository, DataContext context, IUserToClubRepository userToClubRepository)
      {
         this.userRepository = userRepository;
         this.mapper = mapper;
         this.eventRepository = eventRepository;
         this.context = context;
         this.userToClubRepository = userToClubRepository;
      }

      /// <summary>
      /// Gets all events in the system.
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      public IActionResult GetUsers()
      {
         var users = userRepository.GetUsers();
         var usersToReturn = mapper.Map<List<UserDto>>(users);
         return Ok(usersToReturn);
      }


      /// <summary>
      /// Gets event with given ID.
      /// </summary>
      /// <param name="ID">ID of event to be searched.</param>
      /// <returns></returns>
      [HttpGet("{id}")]
      public IActionResult GetUserByID(int ID)
      {
         var user = userRepository.GetUserByID(ID);
         var userToReturn = mapper.Map<UserDto>(user);
         return Ok(userToReturn);
      }

      /// <summary>
      /// Finds a user from the database with given mail.
      /// </summary>
      /// <param name="mail">Mail of the searched user.</param>
      [HttpGet("mail/{mail}")]
      public IActionResult GetUserByMail(string mail)
      {
         var user = userRepository.GetUserByMail(mail);
         var userToReturn = mapper.Map<UserDto>(user);
         return Ok(userToReturn);
      }
      /// <summary>
      /// Adds student event to the user.
      /// </summary>
      /// <param name="eventDto">Data transfer object of student event to be added.</param>
      /// <returns></returns>
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
            EventCost = eventDto.EventCost,
            Capacity = eventDto.Capacity,
            UserId = eventDto.UserID,
            Name = eventDto.Name,
            PlaceName = eventDto.PlaceName,
            Date = eventDto.Date,
            ImageURL = eventDto.ImageURL,
            Description = eventDto.Description,
            IsApproved = eventDto.IsApproved,
            AdminID = 12, // to be changed
            ClubID = 10
         };
         eventHandler = new Context.EventHandler(StudentEventCreator.getInstance());
         var createdEvent = await eventHandler.CreateEvent(eventToCreate, context);
         return StatusCode(201);
      }
      /// <summary>
      /// Deletes user from the system.
      /// </summary>
      /// <param name="userDto">Data transfer object of user to be deleted.</param>
      /// <returns></returns>
      [HttpPost("delete")]
      public async Task<IActionResult> DeleteUser([FromBody] UserDto userDto)
      {
         var userToDelete = userRepository.GetUserByMail(userDto.Mail);
         await userRepository.DeleteUser(userToDelete);
         return StatusCode(201);
      }

      [HttpPost("{id}/changepassword")]
      public async Task<IActionResult> ChangePassword([FromBody] ResetPasswordDto resetPasswordDto)
      {
         if (userRepository.GetUserByMail(resetPasswordDto.Mail) == null)
         {
            ModelState.AddModelError("Mail", "Mail does not exists!");
         }

         if (resetPasswordDto.Password != resetPasswordDto.ConfirmPassword)
         {
            return BadRequest();
         }

         var user = userRepository.GetUserByMail(resetPasswordDto.Mail);


         if (AuthRepository.VerifyPasswordHash(resetPasswordDto.OldPassword, user.PasswordHash, user.PasswordSalt) == false)
         {
            return BadRequest();
         }


         user = await userRepository.ChangePassword(resetPasswordDto.Mail, resetPasswordDto.Password);

         return StatusCode(201);
      }

      [HttpPost("joinClub")]
      public async Task<ActionResult> JoinClub([FromBody] UserToClubDto userToClubDto)
      {

         var userToClub = new UserToClub
         {
            UserId = userToClubDto.UserId,
            ClubId = userToClubDto.ClubId
         };

         await userToClubRepository.Add(userToClub);
         return StatusCode(201);

      }

      [HttpPost("getjoinedevents")]
      public IActionResult GetUserToClubs()
      {
         var userToClubs = userToClubRepository.GetUserToClubs();
         var usersToClubsToReturn = mapper.Map<List<UserToClubDto>>(userToClubs);
         return Ok(usersToClubsToReturn);
      }

   }
}
