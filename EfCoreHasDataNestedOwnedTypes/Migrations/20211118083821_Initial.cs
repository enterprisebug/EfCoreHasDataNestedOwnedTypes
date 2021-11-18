using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreHasDataNestedOwnedTypes.Migrations
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RootEntities");
        }
    }
}
