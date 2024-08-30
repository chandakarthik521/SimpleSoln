using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KRModels.Migrations
{
    /// <inheritdoc />
    public partial class M_Level : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.CreateTable(
                name: "M_Level",
                schema: "User",
                columns: table => new
                {
                    LevelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Level", x => x.LevelID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Level",
                schema: "User");
        }
    }
}
