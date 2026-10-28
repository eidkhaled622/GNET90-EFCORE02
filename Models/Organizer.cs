using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GNET90_EFCORE02.Models;

namespace Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(150)]
        public string ComponyName { get; set; }

        public ICollection<Event> events { get; set; }
        public organizerProfile Profile { get; set; }
    }
}