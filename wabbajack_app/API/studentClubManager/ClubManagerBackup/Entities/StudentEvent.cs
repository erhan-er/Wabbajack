using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class StudentEvent : Event
    {
        public Admin Admin { get; set; }
        public int AdminID { get; set; }
        public bool IsApproved { get; set; }
    }
}
