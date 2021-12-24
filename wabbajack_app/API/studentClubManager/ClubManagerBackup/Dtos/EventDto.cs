using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
   public class EventDto
   {
      public int ID { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public int PlaceID { get; set; }
      public int CategoryID { get; set; }

      public int Cost { get; set; }
      public int Capacity { get; set; }
      public int ClubID { get; set; } // null if event is student event
      public int UserId { get; set; } // null if event is club event

      public string Discriminator = "Event";
   }
}
