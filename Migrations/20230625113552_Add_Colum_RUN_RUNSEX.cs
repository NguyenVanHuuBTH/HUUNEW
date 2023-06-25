using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CUONGDB.Migrations
{
    /// <inheritdoc />
    public partial class Add_Colum_RUN_RUNSEX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RUNSEX",
                table: "RUN",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RUNSEX",
                table: "RUN");
        }
    }
}
