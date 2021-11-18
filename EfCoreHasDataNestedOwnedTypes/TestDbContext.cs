using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreHasDataNestedOwnedTypes
{
    public class TestDbContext : DbContext
    {
        public DbSet<EntityLevel1> EntityLevel1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=127.0.0.1,5433;Initial Catalog=EfCoreHasDataNestedOwnedTypes;User Id=xxx;Password=xxx")
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityLevel1>(b =>
            {
                b.OwnsOne(x => x.OwnedEntity1);
            });

            
        }
    }
}
