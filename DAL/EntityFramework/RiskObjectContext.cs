using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class RiskObjectContext : DbContext
    {
        public RiskObjectContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CodeTestHumanRisks;Trusted_Connection=True;");
            optionsBuilder.UseInMemoryDatabase("RiskObjectContext");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<RisksObject> RisksObjects { get; set; }
    }
}
