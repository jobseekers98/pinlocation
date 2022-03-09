using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Address2
    {
        [Key]
        public int Id { get; set; }
        public string Postal { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int StateId { get; set; }
        public string country { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Address1 { get; set; }
    }

    public class AddressVM2
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Postal { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public int StateId { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string Latitude { get; set; }
        [Required]
        public string Longitude { get; set; }
        [Required]
        public string Address1 { get; set; }

        public string Address2 { get; set; }
        public List<StateMaster> StateDropDownList { get; set; }

        //public List<StateMaster> StateDropDownList { get; set; } = new List<StateMaster>();
    };

}

