using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyWebAPI.Migrations
{
    public partial class addedauthentitation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "CreatedOn", "Login", "Password", "Role" },
                values: new object[] { 1, new DateTime(2022, 5, 22, 23, 26, 51, 439, DateTimeKind.Local).AddTicks(9368), "test", "testowy", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
