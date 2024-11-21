using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManagerFinal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Description", "Genre", "Name", "Rating", "Status" },
                values: new object[] { 1, "young adult", "young adult", "Song of Achilles", 5, "read" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Description", "Genre", "Name", "Rating", "Status" },
                values: new object[] { 2, "fantasy", "fantasy", "Harry Potter and the Prisoner of Azkaban", 5, "read" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Description", "Genre", "Name", "Rating", "Status" },
                values: new object[] { 3, "young adult", "young adult", "I'll Give You the Sun", 4, "will read" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
