using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
    public class ResetPasswordDto
    {
        public String Mail { get; set; }
        public String OldPassword { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }
    }
}
