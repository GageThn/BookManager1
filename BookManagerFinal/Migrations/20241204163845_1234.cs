using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManagerFinal.Migrations
{
    public partial class _1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Books",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Books",
                type: "nvarchar(999)",
                maxLength: 999,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Genre", "Summary" },
                values: new object[] { "The Song of Achilles by Madeline Miller retells the Trojan War through the eyes of Patroclus focusing on his deep, passionate love for the legendary Greek warrior Achilles", "young adult" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Summary",
                value: "Harry Potter enters his third year at HOgwarts only to be greeted by a tense atmosphere caused by a prisson at Azkaban escaping. Harry along with his friends learn of a connection between the prisoner and his parents. Learning of his innocence Harry travels back in time to set things right.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "Summary",
                value: "A brother and sister, who once were inseparable but have driven each other away. As the twins get older, and figure out what kind of people they want to be, they start to see each other and their parents not just as extensions of themselves, but as individuals.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Summary", "Genre" },
                values: new object[] { "young adult", "young adult" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Summary",
                value: "fantasy");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "Summary",
                value: "young adult");
        }
    }
}
