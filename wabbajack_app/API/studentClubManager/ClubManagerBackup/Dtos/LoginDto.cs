using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
   /// <summary>
   /// Data transfer object of Login.
   /// </summary>
   public class LoginDto
   {
      /// <summary>
      /// Mail of the user.
      /// </summary>
      /// <value>Mail of the user.</value>
      public string Mail { get; set; }
      /// <summary>
      /// Password of the user.
      /// </summary>
      /// <value>Password f the user.</value>
      public string Password { get; set; }
   }
}
