using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class ggttyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("4f2bc581-074f-4fe1-853e-65d7d690f19a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("b0bf0bca-ab6d-457a-af1d-fc38f1f6b0e3"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("377b6a0f-6528-4b04-b0a5-c91e001c2ad9"), "Member" },
                    { new Guid("c524b999-c864-4454-acaf-c613fbca6fbe"), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("4f2bc581-074f-4fe1-853e-65d7d690f19a"), "Admin" },
                    { new Guid("b0bf0bca-ab6d-457a-af1d-fc38f1f6b0e3"), "Member" }
                });
        }
    }
}
