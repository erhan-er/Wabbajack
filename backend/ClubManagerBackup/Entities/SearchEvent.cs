using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class SearchEvent : Search
    {
        public List<Event> ListedEvents { get; private set; }
        public List<Event> FilteredEvents { get; private set; }
    }
}
