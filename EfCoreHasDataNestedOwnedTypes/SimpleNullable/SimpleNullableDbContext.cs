using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfCoreHasDataNestedOwnedTypes.SimpleNullable;

public class SimpleNullableDbContext : DbContext
{
    public DbSet<RootEntity> RootEntities { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(
                "Server=127.0.0.1,5433;Initial Catalog=EfCoreHasDataNestedOwnedTypes;User Id=sa;Password=Pass@word")
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RootEntity>(b =>
        {
            b.HasData(RootEntity.All.Select(x => new { x.Id, x.NullableString }));
        });
    }
}