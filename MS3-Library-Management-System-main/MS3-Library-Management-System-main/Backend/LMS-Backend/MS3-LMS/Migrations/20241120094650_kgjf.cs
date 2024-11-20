using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class kgjf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("377b6a0f-6528-4b04-b0a5-c91e001c2ad9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("c524b999-c864-4454-acaf-c613fbca6fbe"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("9e33a0ee-1e91-4a2f-bf64-5202a01ed957"), "Admin" },
                    { new Guid("e63b7597-fb0d-43c6-8704-011843bc8b5c"), "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("9e33a0ee-1e91-4a2f-bf64-5202a01ed957"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("e63b7597-fb0d-43c6-8704-011843bc8b5c"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("377b6a0f-6528-4b04-b0a5-c91e001c2ad9"), "Member" },
                    { new Guid("c524b999-c864-4454-acaf-c613fbca6fbe"), "Admin" }
                });
        }
    }
}
