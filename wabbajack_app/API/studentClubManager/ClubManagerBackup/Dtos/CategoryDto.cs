using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Data transfer object of Category.
   /// </summary>
   public class CategoryDto
   {
      /// <summary>
      /// ID of the category in the database.
      /// </summary>
      /// <value>ID of the category.</value>
      public int ID { get; set; }
      /// <summary>
      /// Name of the category in the database.
      /// </summary>
      /// <value>Name of the category.</value>
      public string CategoryName { get; set; }
   }
}
