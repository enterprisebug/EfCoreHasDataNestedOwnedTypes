using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfCoreHasDataNestedOwnedTypes.ThreeLevel;

public class ThreeLevelDbContext : DbContext
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
                ob.OwnsOne(x => x.OwnedEntityLevel2, iob =>
                {
                    iob.HasData(RootEntity.All.Select(x => new
                    {
                        x.OwnedEntityLevel1.OwnedEntityLevel2.Id,
                        x.OwnedEntityLevel1.OwnedEntityLevel2.MyProperty,
                        OwnedEntityLevel1RootEntityId = x.Id
                    }));
                });

                ob.HasData(RootEntity.All.Select(x => new
                {
                    x.OwnedEntityLevel1.Id,
                    RootEntityId = x.Id,
                    OwnedEntityLevel1RootEntityId = x.Id,
                    OwnedEntityLevel2Id = x.OwnedEntityLevel1.OwnedEntityLevel2.Id
                }));
            });
            b.HasData(RootEntity.All.Select(x => new { x.Id }));
        });
    }
}