using System;
using EfCoreHasDataNestedOwnedTypes.NullableObject;

namespace EfCoreHasDataNestedOwnedTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        var ctx = new NullableObjectDbContext();
        ctx.Database.EnsureDeleted();
        ctx.Database.EnsureCreated();

        var herp = new RootEntity(Guid.NewGuid(), null);

        ctx.Add(herp);
        var entry = ctx.Entry(herp);
        ctx.SaveChanges();


        Console.WriteLine("Hello World!");
    }
}