using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   public class Event
   {
      public Event()
      {
         Participants = new List<User>();
      }
      // properties
      public int ID { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public Club Club { get; set; }
      public int ClubID { get; set; }
      public DateTime Date { get; set; }
      public int CategoryID { get; set; }
      public int PlaceID { get; set; }
      public Notification Notification { get; set; }
      public string ImageURL { get; set; }
      public int Cost { get; set; } // changed from event budget
      public int Capacity { get; set; }
      public List<User> Participants { get; set; }
      public ClubBoardMember ClubBoardMember { get; set; }
      public int UserID { get; set; }
   }
}
