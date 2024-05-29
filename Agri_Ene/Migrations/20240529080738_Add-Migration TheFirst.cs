using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Agri_Ene.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationTheFirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2699f3f6-51da-4310-ada3-e74cda4bace7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94847481-c097-4a5b-aee4-7c360cdb72d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e5daad4-d0a4-4ddc-ba90-74a0fc1294de", null, "farmer", "farmer" },
                    { "f084be5a-988d-4913-99a6-1d46cdab6d11", null, "employee", "employee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e5daad4-d0a4-4ddc-ba90-74a0fc1294de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f084be5a-988d-4913-99a6-1d46cdab6d11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2699f3f6-51da-4310-ada3-e74cda4bace7", null, "employee", "employee" },
                    { "94847481-c097-4a5b-aee4-7c360cdb72d8", null, "farmer", "farmer" }
                });
        }
    }
}
