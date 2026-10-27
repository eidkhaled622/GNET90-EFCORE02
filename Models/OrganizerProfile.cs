using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class organizerProfile
    {
        public int id { get; set; }
        public string Bio { get; set; }
        public string Link { get; set; }
        public string logo { get; set; }
        public int OrganizerID { get; set; }
        public Organizer organizer { get; set; }
    }
}