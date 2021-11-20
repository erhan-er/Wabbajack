using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Club
    {
        public string Name { get; set; }
        public string ClubDescription { get; set; }
        public SoicalMedia SocialMediaAccount { get; set; }
        public Student[] ClubMembers { get; set; }
        public Event[] UpcomingClubEvents { get; set; }
        public Event[] OldClubEvents { get; set; }
        public ClubPresident ClubPresident { get; set; }
        public Student[] ClubFollowers { get; set; }
        public Student[] JoinRequests { get; set; }
        public int ClubBudget { get; set; }
        public Dictionary<ClubBoardMember,string> ClubRoles { get; set; }
    }
}