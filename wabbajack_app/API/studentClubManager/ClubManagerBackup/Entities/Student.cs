using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    [NotMapped]
    public class Student : User
    {
        public Student()
        {
            FollowedClubs = new List<Club>();
            AppliedEvents = new List<Event>();
            CreatedEvents = new List<StudentEvent>();
            Friends = new List<Student>();
            Invitations = new List<Notification>();
        }
        public String Role { get; set; }
        public List<Club> FollowedClubs { get; set; }
        public List<Event> AppliedEvents { get; set; }
        public List<StudentEvent> CreatedEvents { get; set; }
        public List<Student> Friends { get; set; }
        public List<Notification> Invitations { get; set; }
    }
}
