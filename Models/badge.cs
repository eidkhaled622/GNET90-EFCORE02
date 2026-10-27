using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNET90_EFCORE02.Models
{
    public class Badge
    {
        public int id { get; set; }
        public DateTime IssueDate { get; set; }
        public Tier Attendee_Tier { get; set; }
    }
}