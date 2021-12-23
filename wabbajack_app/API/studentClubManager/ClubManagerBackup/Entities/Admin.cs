using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class Admin : User
    {
        public Admin()
        {
            RequestedEvents = new List<StudentEvent>();
        }
        public List<StudentEvent> RequestedEvents { get; set; }
    }
}
