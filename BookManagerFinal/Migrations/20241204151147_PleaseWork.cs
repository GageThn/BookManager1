using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManagerFinal.Migrations
{
    public partial class PleaseWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Books",
                newName: "Synopsis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Synopsis",
                table: "Books",
                newName: "Summary");
        }
    }
}
