using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class SearchClub : Search
    {
        public List<Club> ListedClubs { get; private set; }
    }
}
