using System;

namespace EfCoreHasDataNestedOwnedTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        //var ctx = new TwoLevelDbContext();
        //ctx.Database.EnsureDeleted();
        //ctx.Database.EnsureCreated();

        //var x = new RootEntity(
        //    Guid.Parse("96e1d442-bdd0-4c6f-9d01-624b27abbac3"),
        //    new OwnedEntityLevel1
        //    {
        //        Id = Guid.Parse("8f8eea73-0b43-412a-b0aa-a9338db6e067")
        //        //OwnedEntityLevel2 = new OwnedEntityLevel2 { Id = Guid.Parse("10b5e414-ce2a-440c-af40-3cf41a6d9718"), MyProperty = "Hello 1" }
        //    }
        //);


        //ctx.Add(x);
        //var entry = ctx.Entry(x);
        //var herp = ctx.Entry(x.OwnedEntityLevel1);
        //var derp = ctx.Entry(x.OwnedEntityLevel1.OwnedEntityLevel2);

        Console.WriteLine("Hello World!");
    }
}