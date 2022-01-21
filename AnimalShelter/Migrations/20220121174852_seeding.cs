using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "AvailableForAdoption", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 7, true, "Main Coon", "Male", "George", "Cat" },
                    { 2, 12, true, "Domestic short hair", "Female", "Lilly", "Cat" },
                    { 3, 1, true, "Labrador Retriever", "Male", "Rover", "Dog" },
                    { 4, 4, true, "Dachshund", "Male", "Fido", "Dog" },
                    { 5, 2, true, "Syrian", "Male", "Gerald", "Hamster" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);
        }
    }
}
