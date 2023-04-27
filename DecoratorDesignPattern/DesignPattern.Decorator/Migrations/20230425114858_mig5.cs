using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPattern.Decorator.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageCity",
                table: "Messages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageCity",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
