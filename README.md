# EfCoreHasDataNestedOwnedTypes
Minimal reproducible example

#

	dotnet ef migrations add Initial --context TwoLevelDbContext -o Migrations/TwoLevel

	dotnet ef migrations add Initial --context ThreeLevelDbContext -o Migrations/ThreeLevel