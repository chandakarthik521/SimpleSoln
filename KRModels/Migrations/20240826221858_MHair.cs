using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KRModels.Migrations
{
    /// <inheritdoc />
    public partial class MHair : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_Hair",
                schema: "avatar",
                columns: table => new
                {
                    HairId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HairColour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Hair", x => x.HairId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Hair",
                schema: "avatar");
        }
    }
}
