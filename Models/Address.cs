using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GNET90_EFCORE02.Models
{
    public class Address
    {
        [MaxLength(150)]
        [Required]
        public string street { get; set; }

        [MaxLength(100)]
        [Required]
        public string city { get; set; }

        [MaxLength(100)]
        [Required]
        public string country { get; set; }

        [MaxLength(20)]
        [Required]
        [Column("ZIPCode")]
        public string ZipCode { get; set; }
    }
}