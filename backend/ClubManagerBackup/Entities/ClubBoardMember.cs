using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class ClubBoardMember : User
    {
        public String RoleOfMember { get; set; }
        [NotMapped]
        public List<Event> CreatedEvents { get; set; }
    }
}
