using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
   /// <summary>
   /// Data transfer object of Place.
   /// </summary>
   public class PlaceDto
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
      public string PlaceName { get; set; }
   }
}
