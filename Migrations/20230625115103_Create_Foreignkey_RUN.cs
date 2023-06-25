using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CUONGDB.Migrations
{
    /// <inheritdoc />
    public partial class Create_Foreignkey_RUN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FCTID",
                table: "RUN",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FCTID = table.Column<string>(type: "TEXT", nullable: false),
                    FCTName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FCTID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RUN_FCTID",
                table: "RUN",
                column: "FCTID");

            migrationBuilder.AddForeignKey(
                name: "FK_RUN_Faculty_FCTID",
                table: "RUN",
                column: "FCTID",
                principalTable: "Faculty",
                principalColumn: "FCTID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RUN_Faculty_FCTID",
                table: "RUN");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropIndex(
                name: "IX_RUN_FCTID",
                table: "RUN");

            migrationBuilder.DropColumn(
                name: "FCTID",
                table: "RUN");
        }
    }
}
