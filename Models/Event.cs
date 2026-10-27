using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNET90_EFCORE02.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime startDate { get; set; }
        public string? endDate { get; set; }
        public int maxNumOfAttendee { get; set; }
    }
}