using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.Api.Migrations
{
    /// <inheritdoc />
    public partial class UserConfigurationsAndEntities2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "Password", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 29, 4, 26, 54, 0, DateTimeKind.Unspecified), "admin@gmail.com", "web123$", new DateTime(2024, 2, 29, 4, 26, 54, 0, DateTimeKind.Unspecified), "Asror" },
                    { 2, new DateTime(2024, 2, 29, 4, 26, 54, 0, DateTimeKind.Unspecified), "technicalAdmin@gmail.com", "Aa@123456", new DateTime(2024, 2, 29, 4, 26, 54, 0, DateTimeKind.Unspecified), "MuhammadYusuf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
