using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class User
    {
        public User()
        {
            Notifications = new List<Notification>();
        }
        // properties
        public int ID { get; set; }
        public String Name { get; set; }
        public String Mail { get; set; }
        [JsonIgnore]
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public String Department { get; set; }
        public String Discriminator { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
