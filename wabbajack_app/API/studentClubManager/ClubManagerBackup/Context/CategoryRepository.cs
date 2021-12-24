using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Repository for Category
   /// </summary>
   public class CategoryRepository : ICategoryRepository
   {
      /// <summary>
      /// Database reference.
      /// </summary>
      private DataContext context;

      /// <summary>
      /// Constructor for Category Repository class
      /// </summary>
      /// <param name="context">Database reference.</param>
      public CategoryRepository(DataContext context)
      {
         this.context = context;
      }

      /// <summary>
      /// Adds new category to the database.
      /// </summary>
      /// <param name="newCategory">Category to be added.</param>
      /// <returns>Returns added category.</returns>
      public async Task<Category> AddCategory(Category newCategory)
      {
         await context.Categories.AddAsync(newCategory);
         await context.SaveChangesAsync();
         return newCategory;
      }

      /// <summary>
      /// Deletes category from the database.
      /// </summary>
      /// <param name="categoryToDelete">Category to be deleted.</param>
      /// <returns></returns>
      public async Task DeleteCategory(Category categoryToDelete)
      {
         context.Categories.Remove(categoryToDelete);
         await context.SaveChangesAsync();
      }

      /// <summary>
      /// Finds a category from the databse with given ID.
      /// </summary>
      /// <param name="ID">ID of the searched category.</param>
      /// <returns>Returns category with given ID.</returns>
      public Category GetCategoryByID(int ID)
      {
         var category = context.Categories.FirstOrDefault(c => c.ID == ID);
         return category;
      }

      /// <summary>
      /// Gets all categories from the database.
      /// </summary>
      /// <returns>Returns the list of all categories.</returns>
      public List<Category> GetCategories()
      {
         var categories = context.Categories.ToList();
         return categories;
      }

      /// <summary>
      /// Checks if category with given name exists in the database.
      /// </summary>
      /// <param name="categoryName">Category name to be checked.</param>
      /// <returns>Returns true if category exists, else returns false.</returns>
      public async Task<bool> CategoryExists(string categoryName)
      {
         if (await context.Categories.AnyAsync(x => x.CategoryName == categoryName))
         {
            return true;
         }
         return false;
      }
   }
}
