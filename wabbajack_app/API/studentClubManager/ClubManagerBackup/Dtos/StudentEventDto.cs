using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
    public class StudentEventDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int Capacity { get; set; }
        public int UserID { get; set; }
        public bool IsApproved { get; set; } = false;

        public string Discriminator = "StudentEvent";
    }
}
