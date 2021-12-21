using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    [NotMapped]
    public class StudentEvent : Event
    {
        public Student Student { get; set; }
        public Admin Admin { get; set; }
        public int AdminID { get; set; }
    }
}
