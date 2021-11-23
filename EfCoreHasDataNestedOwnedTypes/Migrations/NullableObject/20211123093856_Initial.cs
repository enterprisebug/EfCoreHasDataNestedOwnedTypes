using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreHasDataNestedOwnedTypes.Migrations.NullableObject
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
                    OwnedEntityLevel1_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RootEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RootEntities",
                columns: new[] { "Id", "OwnedEntityLevel1_Id" },
                values: new object[] { new Guid("96e1d442-bdd0-4c6f-9d01-624b27abbac3"), new Guid("8f8eea73-0b43-412a-b0aa-a9338db6e067") });

            migrationBuilder.InsertData(
                table: "RootEntities",
                column: "Id",
                value: new Guid("aae51dac-016e-472e-ad51-2f09f8cb9fbb"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RootEntities");
        }
    }
}
