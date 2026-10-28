using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GNET90_EFCORE02.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        [MaxLength(150)]
        [Required]
        public string name { get; set; }
        [MaxLength(200)]
        [Required]
        public string Email { get; set; }
        public Address Address { get; set; }
        public Badge? Badge { get; set; }

        [NotMapped]
        public string FullAddress =>
            string.Join(", ", new[] { Address?.street, Address?.city, Address?.country, Address?.ZipCode });
    }
}