using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CUONGDB.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_HUU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HUU",
                columns: table => new
                {
                    HUUID = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    HUUName = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    HUUSđt = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HUU", x => x.HUUID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HUU");
        }
    }
}
