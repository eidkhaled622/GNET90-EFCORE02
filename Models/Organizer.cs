using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ComponyName { get; set; }
        public int ProfileId { get; set; }
        public organizerProfile Profile { get; set; }
    }
}