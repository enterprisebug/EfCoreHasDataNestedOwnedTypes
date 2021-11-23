# EfCoreHasDataNestedOwnedTypes
Minimal reproducible example

# Problem
How to seed entities with `.OwnsOne` and `.HasData` when having nullable objects

## NullableObject (not working)

**Scripts*+*
	dotnet ef migrations add Initial --context NullableObjectDbContext -o Migrations/NullableObject
	dotnet ef migrations remove --context NullableObjectDbContext

## TwoLevelDbContext (working)

**Scripts*+*
	dotnet ef migrations add Initial --context TwoLevelDbContext -o Migrations/TwoLevel
	dotnet ef migrations remove --context TwoLevelDbContext


## ThreeLevelDbContext (working)

**Scripts*+*
	dotnet ef migrations add Initial --context ThreeLevelDbContext -o Migrations/ThreeLevel
	dotnet ef migrations remove --context TwoLevelDbContext

## SimpleNullableDbContext (working)

**Scripts*+*
	dotnet ef migrations add Initial --context SimpleNullableDbContext -o Migrations/SimpleNullable
	dotnet ef migrations remove --context SimpleNullableDbContext

