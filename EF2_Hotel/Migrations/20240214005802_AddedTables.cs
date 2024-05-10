using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF2_Hotel.Migrations
{
    /// <inheritdoc />
    public partial class AddedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frontend",
                columns: table => new
                {
                    User_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pass_word = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frontend", x => x.User_name);
                });

            migrationBuilder.CreateTable(
                name: "Kitchen",
                columns: table => new
                {
                    User_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pass_word = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchens", x => x.User_name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frontend");

            migrationBuilder.DropTable(
                name: "Kitchens");
        }
    }
}
