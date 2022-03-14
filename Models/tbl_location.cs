using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class tbl_location
    {
        [Key]
        public int Id { get; set; }
        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Address { get; set; }


        public string Latitude1 { get; set; }

        public string Longitude1 { get; set; }

        public string Address1 { get; set; }

    }
}
