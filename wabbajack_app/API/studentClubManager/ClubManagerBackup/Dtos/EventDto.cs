using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
   public class EventDto
   {
      public string Name { get; set; }
      public string Description { get; set; }
      public string Discriminator = "Event";

   }
}
