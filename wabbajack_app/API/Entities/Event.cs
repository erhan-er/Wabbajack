using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Category;

namespace Event
{
   public class Event
   {
      // properties
      public string Name { get; private set; }
      public string Description { get; private set; }
      public Club Club { get; private set; }
      public DateTime Date { get; private set; }
      public Category Category { get; private set; }
      public Place Place { get; private set; }
      public Notification Notification { get; private set; }
      public string ImageURL { get; private set; }
      public int EventCost { get; private set; } // changed from event budget
      public int Capacity { get; private set; }
      public List<Student> Participants { get; private set; }

      // methods

      void AddParticipant(Studnet newParticipant)
      {
         Participants.Add(newParticipant);
      }

   }
}