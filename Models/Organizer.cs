using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GNET90_EFCORE02.Models;

namespace Models
{
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ComponyName { get; set; }

        public ICollection<Event> events { get; set; }
        public organizerProfile Profile { get; set; }
    }
}