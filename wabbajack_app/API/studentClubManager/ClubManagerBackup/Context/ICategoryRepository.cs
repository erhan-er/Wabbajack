using ClubManagerBackup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   /// <summary>
   /// Interface for CategoryRepository
   /// </summary>
   public interface ICategoryRepository
   {
      /// <summary>
      /// Adds new category to the database.
      /// </summary>
      /// <param name="newCategory">Category to be added.</param>
      /// <returns>Returns added category.</returns>
      Task<Category> AddCategory(Category newCategory);

      /// <summary>
      /// Deletes category from the database.
      /// </summary>
      /// <param name="categoryToDelete">Category to be deleted.</param>
      /// <returns></returns>
      Task DeleteCategory(Category categoryToDelete);

      /// <summary>
      /// Checks if category with given name exists in the database.
      /// </summary>
      /// <param name="categoryName">Category name to be checked.</param>
      /// <returns>Returns true if category exists, else returns false.</returns>
      Task<bool> CategoryExists(string categoryName);

      /// <summary>
      /// Gets all categories from the database.
      /// </summary>
      /// <returns>Returns the list of all categories.</returns>
      List<Category> GetCategories();

      /// <summary>
      /// Finds a category from the databse with given ID.
      /// </summary>
      /// <param name="ID">ID of the searched category.</param>
      /// <returns>Returns category with given ID.</returns>
      Category GetCategoryByID(int ID);
   }
}