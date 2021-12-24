using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   public interface ICategoryRepository
   {
      Task<Category> AddCategory(Category newCategory);
      Task DeleteCategory(Category categoryToDelete);
      Task<bool> CategoryExists(string categoryName);
      List<Category> GetCategories();
      Category GetCategoryByID(int ID);
   }
}