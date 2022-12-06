using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Computer_maintenance.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
