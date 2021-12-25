using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   public class UserToClub
   {
      public int ID { get; set; }
      public int UserId { get; set; }
      public int ClubId { get; set; }
   }
}