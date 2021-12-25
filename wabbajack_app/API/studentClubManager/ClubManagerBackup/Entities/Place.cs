using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Place object.
   /// </summary>
   public class Place
   {
      /// <summary>
      /// ID of the place in the database.
      /// </summary>
      /// <value>ID of the place.</value>
      public int ID { get; set; }
      /// <summary>
      /// Building name of the place in the database.
      /// </summary>
      /// <value>Building name of the place.</value>
      public string Building { get; set; }
      /// <summary>
      /// Room name of the place in the database.
      /// </summary>
      /// <value>Room name of the place.</value>
      public string Room { get; set; }
   }
}
