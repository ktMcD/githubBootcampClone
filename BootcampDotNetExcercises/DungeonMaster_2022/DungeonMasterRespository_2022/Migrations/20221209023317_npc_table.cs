using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonMasterRespository2022.Migrations
{
    /// <inheritdoc />
    public partial class npctable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Npcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NpcName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Backstory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFriendly = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Greeting = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Npcs", x => x.Id);
                }); ;
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Npcs");
        }
    }
}
