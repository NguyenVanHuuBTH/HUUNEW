﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CUONGDB.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_RUN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RUN",
                columns: table => new
                {
                    RUNID = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    RUNNAME = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    RUNADDRESS = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUN", x => x.RUNID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RUN");
        }
    }
}
