using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManagerFinal.Migrations
{
    public partial class _12052024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Books",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(999)",
                oldMaxLength: 999);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Genre", "Summary" },
                values: new object[] { "young adult", "The Song of Achilles by Madeline Miller retells the Trojan War through the eyes of Patroclus focusing on his deep, passionate love for the legendary Greek warrior Achilles" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Books",
                type: "nvarchar(999)",
                maxLength: 999,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Genre", "Summary" },
                values: new object[] { "The Song of Achilles by Madeline Miller retells the Trojan War through the eyes of Patroclus focusing on his deep, passionate love for the legendary Greek warrior Achilles", "young adult" });
        }
    }
}
