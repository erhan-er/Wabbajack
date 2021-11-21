using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class Admin : User
    {
        public List<StudentEvent> RequestedEvents { get; set; }
        public List<Student> Accounts { get; set; }
    }
}
