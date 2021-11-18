using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreHasDataNestedOwnedTypes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntityLevel1s",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnedEntity1_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnedEntity1_MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityLevel1s", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntityLevel1s");
        }
    }
}
