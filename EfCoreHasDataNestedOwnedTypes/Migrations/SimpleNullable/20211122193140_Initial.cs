using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreHasDataNestedOwnedTypes.Migrations.SimpleNullable
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RootEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NullableString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RootEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RootEntities",
                columns: new[] { "Id", "NullableString" },
                values: new object[] { new Guid("96e1d442-bdd0-4c6f-9d01-624b27abbac3"), "Hi" });

            migrationBuilder.InsertData(
                table: "RootEntities",
                columns: new[] { "Id", "NullableString" },
                values: new object[] { new Guid("aae51dac-016e-472e-ad51-2f09f8cb9fbb"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RootEntities");
        }
    }
}
