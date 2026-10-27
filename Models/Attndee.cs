using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNET90_EFCORE02.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public Badge? Badge { get; set; }
    }
}