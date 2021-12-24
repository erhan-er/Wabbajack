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
   /// Controller class for Categories
   /// </summary>
   [Produces("application/json")]
   [Route("api/Categories")]
   public class CategoryController : Controller
   {
      private ICategoryRepository categoryRepository;
      private IConfiguration configuration;
      private IMapper mapper;
      private Context.EventHandler eventHandler;
      private DataContext context;

      /// <summary>
      /// Constructor for AuthController
      /// </summary>
      /// <param name="categoryRepository">CategoryRepository reference.</param>
      /// <param name="configuration">Configuration reference.</param>
      /// <param name="mapper">Mapper reference.</param>
      /// <param name="context">Database reference.</param>
      public CategoryController(ICategoryRepository categoryRepository, IConfiguration configuration, IMapper mapper, DataContext context)
      {
         this.categoryRepository = categoryRepository;
         this.configuration = configuration;
         this.context = context;
         this.mapper = mapper;
      }

      /// <summary>
      /// Adds category to the system.
      /// </summary>
      /// <param name="categoryDto">Data transfer object of category to be added.</param>
      /// <returns></returns>
      [HttpPost("add")]
      public async Task<IActionResult> AddCategory([FromBody] CategoryDto categoryDto)
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
         var createdCategory = await categoryRepository.AddCategory(categoryToCreate);
         return StatusCode(201);
      }

      /// <summary>
      /// Deletes category from the system.
      /// </summary>
      /// <param name="categoryDto">Data transfer object of category to be deleted.</param>
      /// <returns></returns>
      [HttpPost("delete")]
      public async Task<IActionResult> DeleteCategory([FromBody] CategoryDto categoryDto)
      {
         var categoryToDelete = categoryRepository.GetCategoryByID(categoryDto.ID);
         await categoryRepository.DeleteCategory(categoryToDelete);
         return StatusCode(201);
      }

      /// <summary>
      /// Gets all categories in the system.
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      public IActionResult GetCategories()
      {
         var categorys = categoryRepository.GetCategories();
         var categorysToReturn = mapper.Map<List<CategoryDto>>(categorys);
         return Ok(categorysToReturn);
      }

      /// <summary>
      /// Gets category with given ID.
      /// </summary>
      /// <param name="ID">ID of category to be searched.</param>
      /// <returns></returns>
      [HttpGet("{id}")]
      public IActionResult GetCategoryByID(int ID)
      {
         var category = categoryRepository.GetCategoryByID(ID);
         var categoryToReturn = mapper.Map<CategoryDto>(category);
         return Ok(categoryToReturn);
      }


   }
}
