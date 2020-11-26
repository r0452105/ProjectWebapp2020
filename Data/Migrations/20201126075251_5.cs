using Microsoft.EntityFrameworkCore.Migrations;

namespace Testing0._1.Data.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Resultaat",
                table: "Uitslag",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resultaat",
                table: "Uitslag");
        }
    }
}
