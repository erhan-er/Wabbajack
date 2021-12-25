using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
   /// <summary>
   /// Data transfer object of Register.
   /// </summary>
   public class RegisterDto
   {
      /// <summary>
      /// Name of the user to be registered.
      /// </summary>
      /// <value>Name of the user.</value>
      public string Name { get; set; }
      /// <summary>
      /// Password of the user to be registered.
      /// </summary>
      /// <value>Password of the user.</value>
      public string Password { get; set; }
      /// <summary>
      /// Mail of the user to be registered.
      /// </summary>
      /// <value>Mail of the user.</value>
      public string Mail { get; set; }
      /// <summary>
      /// Department of the user to be registered.
      /// </summary>
      /// <value></value>
      public string Department { get; set; }
      /// <summary>
      /// Discriminator to discriminate user types.
      /// </summary>
      public string Discriminator = "Student";
   }
}
