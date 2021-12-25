using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Club roles object.
   /// </summary>
   public class ClubRole
   {
      /// <summary>
      /// ID of the club role.
      /// </summary>
      /// <value>Id of the club role.</value>
      public int ID { get; set; }
      /// <summary>
      /// Name of the club role.
      /// </summary>
      /// <value>Name of the club role.</value>
      public string ClubRoleName { get; set; }
   }
}
