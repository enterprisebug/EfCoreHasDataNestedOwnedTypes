using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreHasDataNestedOwnedTypes.Migrations.ThreeLevel
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
                    OwnedEntityLevel1_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnedEntityLevel1_OwnedEntityLevel2_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnedEntityLevel1_OwnedEntityLevel2_MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RootEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RootEntities",
                columns: new[] { "Id", "OwnedEntityLevel1_Id", "OwnedEntityLevel1_OwnedEntityLevel2_Id", "OwnedEntityLevel1_OwnedEntityLevel2_MyProperty" },
                values: new object[] { new Guid("96e1d442-bdd0-4c6f-9d01-624b27abbac3"), new Guid("8f8eea73-0b43-412a-b0aa-a9338db6e067"), new Guid("32e7b4cd-9bd2-41fd-9376-d3589cc273eb"), "Hello 1" });

            migrationBuilder.InsertData(
                table: "RootEntities",
                columns: new[] { "Id", "OwnedEntityLevel1_Id", "OwnedEntityLevel1_OwnedEntityLevel2_Id", "OwnedEntityLevel1_OwnedEntityLevel2_MyProperty" },
                values: new object[] { new Guid("aae51dac-016e-472e-ad51-2f09f8cb9fbb"), new Guid("701b2c44-c41f-450a-bc80-626b8045373d"), new Guid("5f1aae05-57c9-43bf-ae0b-4292df28f1ac"), "Hello 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RootEntities");
        }
    }
}
