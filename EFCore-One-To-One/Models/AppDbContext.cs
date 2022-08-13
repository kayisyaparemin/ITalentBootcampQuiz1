using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_One_To_One.Models
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Capital> Capitals { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=ITalentQuizDbOneToOne;trusted_connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Capital>().HasOne(x => x.Country).WithOne(x => x.Capital).HasForeignKey<Capital>(x => x.CountryId);
            modelBuilder.Entity<Country>().HasOne(x => x.Capital).WithOne(x => x.Country).HasForeignKey<Country>(x => x.CapitalId);
        }
    }
}
