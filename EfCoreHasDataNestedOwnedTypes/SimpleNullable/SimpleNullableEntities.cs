using System;
using System.Collections.Generic;

namespace EfCoreHasDataNestedOwnedTypes.SimpleNullable;

public class RootEntity
{
    protected RootEntity()
    {
    }

    public RootEntity(Guid id, string? nullableString)
    {
        Id = id;
        NullableString = nullableString;
    }

    public Guid Id { get; set; }
    public string? NullableString { get; set; }

    #region Only for HasData

    public static RootEntity PredefinedEntity11 { get; } =
        new(
            Guid.Parse("96e1d442-bdd0-4c6f-9d01-624b27abbac3"),
            "Hi"
        );

    public static RootEntity PredefinedEntity12 { get; } =
        new(
            Guid.Parse("aae51dac-016e-472e-ad51-2f09f8cb9fbb"),
            null
        );

    public static IReadOnlyList<RootEntity> All { get; } =
        new List<RootEntity>(new[] { PredefinedEntity11, PredefinedEntity12 }).AsReadOnly();

    #endregion
}