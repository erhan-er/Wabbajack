using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class User
    {
        // properties
        public int ID { get; set; }
        public String Name { get; set; }
        public String Mail { get; set; }
        public String Password { get; set; }
        public String Department { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
