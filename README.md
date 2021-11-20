# EfCoreHasDataNestedOwnedTypes
Minimal reproducible example

# Problem
How to seed entities with `.HasData` when having more than two levels

# Solution
see `ThreeLevelDbContext` for a working solution

## TwoLevelDbContext
TwoLevelDbContext is working fine.

See Migration `20211120092746_Initial` which generated insert statements for a entity with two levels

**Scripts*+*
	dotnet ef migrations add Initial --context TwoLevelDbContext -o Migrations/TwoLevel
	dotnet ef migrations remove --context TwoLevelDbContext


## ThreeLevelDbContext

**Scripts*+*
	dotnet ef migrations add Initial --context ThreeLevelDbContext -o Migrations/ThreeLevel
	dotnet ef migrations remove --context TwoLevelDbContext