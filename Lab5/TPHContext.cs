using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class TPHContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }

       
    }
}
