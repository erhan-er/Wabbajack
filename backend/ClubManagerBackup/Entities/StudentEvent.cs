using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class StudentEvent : Event
    {
        public Student Student { get; set; }
    }
}
