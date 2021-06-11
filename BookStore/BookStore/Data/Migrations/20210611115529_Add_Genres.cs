using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class Add_Genres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "a70a3c56-35d1-403c-a", "All Fiction Books", "Fiction" },
                    { "d4406cd7-c789-45df-b", "All Fantasy Books", "Fantasy" },
                    { "db2fe0ad-2f7f-4115-9", "All Romance Books", "Romance" },
                    { "e001aaa9-3285-4c0b-a", "All Horror  Books", "Horror" },
                    { "cf23a14f-4554-41d5-b", "All Poetry & Drama Books", "Poetry & Drama" },
                    { "c9f25236-e26b-4049-a", "All Thriller Books", "Thriller " },
                    { "c3f54c84-e68c-478b-8", "All Children's Books Books", "Children's Books" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "a70a3c56-35d1-403c-a");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "c3f54c84-e68c-478b-8");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "c9f25236-e26b-4049-a");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "cf23a14f-4554-41d5-b");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "d4406cd7-c789-45df-b");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "db2fe0ad-2f7f-4115-9");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "e001aaa9-3285-4c0b-a");
        }
    }
}
