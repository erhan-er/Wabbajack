using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class Club
    {
        public Club()
        {
            StudentsClubMembers = new List<User>();
            //StudentsClubFollowers = new List<User>();
            //StudentsJoinRequests = new List<User>();
            EventsOld = new List<Event>();
            ClubRoles = new List<ClubRole>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string ClubDescription { get; set; }
        public List<User> StudentsClubMembers { get; set; }
//        public List<User> StudentsClubFollowers { get; set; }
//        public List<User> StudentsJoinRequests { get; set; }
//        public List<Event> EventsUpcoming { get; set; }
        public List<Event> EventsOld { get; set; }
        public ClubPresident ClubPresident { get; set; }
        public int ClubBudget { get; set; }
        public List<ClubRole> ClubRoles { get; set; }
    }
}
