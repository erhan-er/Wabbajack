using AutoMapper;
using ClubManagerBackup.Context;
using ClubManagerBackup.Dtos;
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
        private IMapper mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
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


    }
}
