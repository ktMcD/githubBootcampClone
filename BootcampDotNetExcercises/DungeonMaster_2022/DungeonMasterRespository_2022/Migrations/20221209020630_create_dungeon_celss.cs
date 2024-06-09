using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonMasterRespository2022.Migrations
{
    /// <inheritdoc />
    public partial class createdungeoncelss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DungeonCells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NumberOfEnemies = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    ContainsBossMonster = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ContainsTrap = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DungeonCells", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DungeonCells");
        }
    }
}
