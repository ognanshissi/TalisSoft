using Microsoft.EntityFrameworkCore.Migrations;

namespace TalisSoft.Octopus.Persistence.Migrations
{
    public partial class AddComputeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "text",
                nullable: true,
                computedColumnSql: "\"FirstName\" || ' ' || \"LastName\"",
                stored: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldComputedColumnSql: "\"FirstName\" || ' ' || \"LastName\"");
        }
    }
}
