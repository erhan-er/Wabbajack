using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
    public class RegisterDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Department { get; set; }
        public string Discriminator = "Student";
    }
}
