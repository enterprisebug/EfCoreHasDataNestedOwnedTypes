using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfCoreHasDataNestedOwnedTypes
{
    public class TestDbContext : DbContext
    {
        public DbSet<RootEntity> RootEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    "Server=127.0.0.1,5433;Initial Catalog=EfCoreHasDataNestedOwnedTypes;User Id=sa;Password=xxx")
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RootEntity>(b =>
            {
                b.OwnsOne(x => x.OwnedEntityLevel1, ob => { ob.OwnsOne(x => x.OwnedEntityLevel2); });
            });
        }
    }
}