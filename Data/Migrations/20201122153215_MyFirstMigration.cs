using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetData",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(maxLength: 150, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<string>(maxLength: 150, nullable: true),
                    YearSeason = table.Column<string>(maxLength: 150, nullable: true),
                    ContractNumber = table.Column<string>(maxLength: 150, nullable: true),
                    ContractCount = table.Column<string>(maxLength: 150, nullable: true),
                    NoContractCount = table.Column<string>(maxLength: 150, nullable: true),
                    InvoiceNumber = table.Column<string>(maxLength: 150, nullable: true),
                    Count = table.Column<string>(maxLength: 150, nullable: true),
                    PerSale = table.Column<string>(maxLength: 150, nullable: true),
                    NetSales = table.Column<string>(maxLength: 150, nullable: true),
                    Discount = table.Column<string>(maxLength: 150, nullable: true),
                    SalesTax = table.Column<string>(maxLength: 150, nullable: true),
                    ReturnedCount = table.Column<string>(maxLength: 150, nullable: true),
                    RefundAmount = table.Column<string>(maxLength: 150, nullable: true),
                    ReceivedMoney = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetData");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
