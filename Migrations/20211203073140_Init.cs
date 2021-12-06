using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseWork.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GridColumn = table.Column<int>(type: "int", nullable: false),
                    GridRow = table.Column<int>(type: "int", nullable: false),
                    Page = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeFrom = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimeTo = table.Column<TimeSpan>(type: "time", nullable: false),
                    Members = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The nickname of user"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The password of user")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
