using System;
using System.Linq;
using EfCoreHasDataNestedOwnedTypes.NullableObjectNestedNonNullable;
using Microsoft.EntityFrameworkCore;

namespace EfCoreHasDataNestedOwnedTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        var ctx = new NullableObjectNestedNonNullableDbContext();
        ctx.Database.EnsureDeleted();
        ctx.Database.EnsureCreated();

        var datas = ctx
            .RootEntities
            .Include(x => x.OwnedEntityLevel1.OwnedEntityLevel2)
            .ToList();

        Console.WriteLine("Hello World!");
    }
}