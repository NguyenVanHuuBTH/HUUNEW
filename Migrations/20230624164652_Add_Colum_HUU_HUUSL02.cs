using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CUONGDB.Migrations
{
    /// <inheritdoc />
    public partial class Add_Colum_HUU_HUUSL02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HUUSL02",
                table: "HUU",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HUUSL02",
                table: "HUU");
        }
    }
}
