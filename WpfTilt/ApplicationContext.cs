using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTilt
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<Mouse> Mouses { get; set; }
        public DbSet<SystemUnit> SystemUnits{ get; set; }

        public ApplicationContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=oopr_lab;Trusted_Connection=True;");
        }
    }
}
