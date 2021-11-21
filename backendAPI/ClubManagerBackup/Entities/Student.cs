using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class Student : User
    {
        public String Role { get; set; }
        public List<Club> FollowedClubs { get; set; }
        public List<Club> JoinedClubs { get; set; }
        //public List<Event> AppliedEvents { get; set; }
        public List<StudentEvent> CreatedEvents { get; set; }
        public List<Club> IgnoredClubs { get; set; }
        public List<Event> OldEvents { get; set; }
        public List<Student> Friends { get; set; }
        public List<Notification> Invitations { get; set; }
    }
}
