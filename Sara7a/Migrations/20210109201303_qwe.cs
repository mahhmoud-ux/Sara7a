using Microsoft.EntityFrameworkCore.Migrations;

namespace tharaha.Migrations
{
    public partial class qwe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgUrl",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgUrl",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
