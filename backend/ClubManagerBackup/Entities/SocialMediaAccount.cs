using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class SocialMediaAccount
    {
        public int ID { get; set; }
        public string WhatsappLink { get; set; }
        public string TwitterLink { get; set; }
        public string FacebookLink { get; set; }
        public string TelegramLink { get; set; }
        public string LinkedInLink { get; set; }
    }
}
