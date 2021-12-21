using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    [NotMapped]
    public class Admin : User
    {
        public Admin()
        {
            RequestedEvents = new List<StudentEvent>();
            Accounts = new List<Student>();
        }
        public List<StudentEvent> RequestedEvents { get; set; }
        public List<Student> Accounts { get; set; }
    }
}
