using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GNET90_EFCORE02.Models
{
    public class Address
    {
        [MaxLength(150)]
        public string street { get; set; }

        [MaxLength(100)]
        public string city { get; set; }

        [MaxLength(100)]
        public string country { get; set; }

        [MaxLength(20)]
        public string ZipCode { get; set; }
    }
}