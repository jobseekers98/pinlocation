using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) 
        {
        
        
        }
      public DbSet<tbl_location> tbl_Locations { get; set; }
        public DbSet<StateMaster> tbl_SaveState { get; set; }
        public DbSet<Address> tbl_SaveAddress { get; set; }

    }
}
