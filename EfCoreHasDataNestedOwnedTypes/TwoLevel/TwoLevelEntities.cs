using System;
using System.Collections.Generic;

namespace EfCoreHasDataNestedOwnedTypes.TwoLevel;

public class RootEntity
{
    protected RootEntity()
    {
    }

    public RootEntity(Guid id, OwnedEntityLevel1 ownedEntityLevel1)
    {
        Id = id;
        OwnedEntityLevel1 = ownedEntityLevel1;
    }


    public Guid Id { get; set; }

    public OwnedEntityLevel1 OwnedEntityLevel1 { get; set; }


    #region Only for HasData

    public static RootEntity PredefinedEntity11 { get; } =
        new(
            Guid.Parse("96e1d442-bdd0-4c6f-9d01-624b27abbac3"),
            new OwnedEntityLevel1
            {
                Id = Guid.Parse("8f8eea73-0b43-412a-b0aa-a9338db6e067")
            }
        );

    public static RootEntity PredefinedEntity12 { get; } =
        new(
            Guid.Parse("aae51dac-016e-472e-ad51-2f09f8cb9fbb"),
            new OwnedEntityLevel1
            {
                Id = Guid.Parse("701b2c44-c41f-450a-bc80-626b8045373d")
            }
        );

    public static IReadOnlyList<RootEntity> All { get; } =
        new List<RootEntity>(new[] { PredefinedEntity11, PredefinedEntity12 }).AsReadOnly();

    #endregion
}

public class OwnedEntityLevel1
{
    public Guid Id { get; set; }
}