using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class StateMaster
    {

        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}
