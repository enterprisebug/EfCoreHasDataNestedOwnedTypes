using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfCoreHasDataNestedOwnedTypes.NullableObject;

public class NullableObjectDbContext : DbContext
{
    public DbSet<RootEntity> RootEntities { get; set; }

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
            b.OwnsOne(x => x.OwnedEntityLevel1, ob =>
            {
                ob.HasData(RootEntity.All.Select(x => new
                    { OwnedEntityLevel1 = new OwnedEntityLevel1(), RootEntityId = x.Id }));
            });
            b.HasData(RootEntity.All.Select(x => new { x.Id }));
        });
    }
}