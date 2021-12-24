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
   [Route("api/Categories")]
   public class CategoryController : Controller
   {
      private ICategoryRepository categoryRepository;
      private IConfiguration configuration;
      private IMapper mapper;
      private Context.EventHandler eventHandler;
      private DataContext context;

      public CategoryController(ICategoryRepository categoryRepository, IConfiguration configuration, IMapper mapper, DataContext context)
      {
         this.categoryRepository = categoryRepository;
         this.configuration = configuration;
         this.context = context;
         this.mapper = mapper;
      }

      [HttpPost("add")]
      public async Task<IActionResult> AddEvent([FromBody] CategoryDto categoryDto)
      {
         if (await categoryRepository.CategoryExists(categoryDto.CategoryName))
         {
            ModelState.AddModelError("Name", "Name already exists");
         }

         if (!ModelState.IsValid)
         {
            return BadRequest(ModelState);
         }

         var categoryToCreate = new Category
         {
            CategoryName = categoryDto.CategoryName,
         };
         var createdEvent = await categoryRepository.AddCategory(categoryToCreate);
         return StatusCode(201);
      }


      [HttpPost("delete")]
      public async Task<IActionResult> DeleteEvent([FromBody] CategoryDto categoryDto)
      {
         var categoryToDelete = categoryRepository.GetCategoryByID(categoryDto.ID);
         await categoryRepository.DeleteCategory(categoryToDelete);
         return StatusCode(201);
      }

      [HttpGet]
      public IActionResult GetEvents()
      {
         var categorys = categoryRepository.GetCategories();
         var categorysToReturn = mapper.Map<List<CategoryDto>>(categorys);
         return Ok(categorysToReturn);
      }

      [HttpGet("{id}")]
      public IActionResult GetEventByID(int ID)
      {
         var category = categoryRepository.GetCategoryByID(ID);
         var categoryToReturn = mapper.Map<CategoryDto>(category);
         return Ok(categoryToReturn);
      }


   }
}
