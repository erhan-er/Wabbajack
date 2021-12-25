using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
   /// <summary>
   /// Data transfer object of User.
   /// </summary>
   public class UserDto
   {
      /// <summary>
      /// ID of the user in the database.
      /// </summary>
      /// <value>ID of the user.</value>
      public int ID { get; set; }
      /// <summary>
      /// Name of the user in the database.
      /// </summary>
      /// <value>Name of the user.</value>
      public string Name { get; set; }
      /// <summary>
      /// Mail of the user in the database.
      /// </summary>
      /// <value>Mail of the user.</value>
      public string Mail { get; set; }
      /// <summary>
      /// Department of the user in the database.
      /// </summary>
      /// <value>Department of the user.</value>
      public string Department { get; set; }
   }
}
