using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class TPCContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PC>().Map(map =>
            {
                map.MapInheritedProperties().ToTable("PCs");
            });

            modelBuilder.Entity<Laptop>().Map(map =>
            {
                map.MapInheritedProperties().ToTable("Laptopy");
            });
        }
    }
}
