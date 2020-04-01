using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class TSContext : DbContext
    {
        public DbSet<TSComputer> Computers { get; set; }
        public DbSet<Server> Servers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TSComputer>()
                .HasRequired(tsc => tsc.Server)
                .WithRequiredDependent(s => s.Computer);

            modelBuilder.Entity<TSComputer>().ToTable("TsComputery");
            modelBuilder.Entity<Server>().ToTable("TsKomputery");
        }
    }
}
