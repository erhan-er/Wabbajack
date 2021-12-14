using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class Event
    {
        // properties
        public int ID { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Club Club { get; set; }
        public int ClubID { get; set; }
        public DateTime Date { get; private set; }
        public Category Category { get; private set; }
        public Place Place { get; private set; }
        public Notification Notification { get; private set; }
        public string ImageURL { get; private set; }
        public int EventCost { get; private set; } // changed from event budget
        public int Capacity { get; private set; }
        public List<User> Participants { get; private set; }
        public ClubBoardMember ClubBoardMember { get; set; }
        public int UserID { get; set; }
    }
}
