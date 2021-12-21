using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    [NotMapped]
    public class ClubBoardMember : User
    {
        public ClubBoardMember()
        {
            CreatedEvents = new List<Event>();
        }
        public String RoleOfMember { get; set; }
        public List<Event> CreatedEvents { get; set; }
    }
}
