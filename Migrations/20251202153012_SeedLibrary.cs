using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class SeedLibrary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "CollectionId", "CoverImg", "Description", "GenreId", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "hp1.jpg", "The first book in the Harry Potter saga, following the young wizard Harry Potter.", 1, "Harry Potter and the Philosopher's Stone" },
                    { 2, 1, 1, "hp2.jpg", "Harry returns to Hogwarts for his second year and faces new dangers.", 1, "Harry Potter and the Chamber of Secrets" },
                    { 3, 1, 1, "hp3.jpg", "Harry faces Sirius Black and uncovers a deeper mystery.", 1, "Harry Potter and the Prisoner of Azkaban" },
                    { 4, 2, 1, "1984.jpg", "A dystopian novel about totalitarianism and surveillance.", 2, "1984" },
                    { 5, 2, 1, "animalfarm.jpg", "A political satire allegory with farm animals.", 2, "Animal Farm" },
                    { 6, 1, 1, "hp4.jpg", "Harry enters a dangerous magical tournament.", 1, "Harry Potter and the Goblet of Fire" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);
        }
    }
}
