using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KRModels.Migrations
{
    /// <inheritdoc />
    public partial class databasecreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "avatar");

            migrationBuilder.CreateTable(
                name: "M_Skin",
                schema: "avatar",
                columns: table => new
                {
                    SkinID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkinColour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Skin", x => x.SkinID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Skin",
                schema: "avatar");
        }
    }
}
