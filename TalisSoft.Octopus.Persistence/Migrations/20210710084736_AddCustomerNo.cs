using Microsoft.EntityFrameworkCore.Migrations;

namespace TalisSoft.Octopus.Persistence.Migrations
{
    public partial class AddCustomerNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "CustomerNumbers",
                startValue: 1000L,
                incrementBy: 5);

            migrationBuilder.AddColumn<int>(
                name: "CustomerNo",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValueSql: "nextval('\"CustomerNumbers\"')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "CustomerNumbers");

            migrationBuilder.DropColumn(
                name: "CustomerNo",
                table: "Customers");
        }
    }
}
