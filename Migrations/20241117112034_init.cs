﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Operations_Using_AJAX.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SWIFT_Code = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}