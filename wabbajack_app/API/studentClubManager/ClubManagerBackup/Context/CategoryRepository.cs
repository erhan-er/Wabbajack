using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClubManagerBackup.Context
{
   public class CategoryRepository : ICategoryRepository
   {
      private DataContext context;

      public CategoryRepository(DataContext context)
      {
         this.context = context;
      }

      public async Task<Category> AddCategory(Category newCategory)
      {
         await context.Categories.AddAsync(newCategory);
         await context.SaveChangesAsync();
         return newCategory;
      }

      public async Task DeleteCategory(Category categoryToDelete)
      {
         context.Categories.Remove(categoryToDelete);
         await context.SaveChangesAsync();
      }

      public Category GetCategoryByID(int ID)
      {
         var category = context.Categories.FirstOrDefault(c => c.ID == ID);
         return category;
      }

      public List<Category> GetCategories()
      {
         var categories = context.Categories.ToList();
         return categories;
      }

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
