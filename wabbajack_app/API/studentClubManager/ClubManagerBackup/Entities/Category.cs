using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Category object.
   /// </summary>
   public class Category
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
