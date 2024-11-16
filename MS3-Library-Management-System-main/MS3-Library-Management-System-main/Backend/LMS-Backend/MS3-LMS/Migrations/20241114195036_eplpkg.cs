using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class eplpkg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("5e3e5d3e-5966-4913-9a48-d90cb281fd3f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("78fa6f2a-2b98-4d90-b0df-b91bcd1f3069"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("4f2bc581-074f-4fe1-853e-65d7d690f19a"), "Admin" },
                    { new Guid("b0bf0bca-ab6d-457a-af1d-fc38f1f6b0e3"), "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("5e3e5d3e-5966-4913-9a48-d90cb281fd3f"), "Member" },
                    { new Guid("78fa6f2a-2b98-4d90-b0df-b91bcd1f3069"), "Admin" }
                });
        }
    }
}
