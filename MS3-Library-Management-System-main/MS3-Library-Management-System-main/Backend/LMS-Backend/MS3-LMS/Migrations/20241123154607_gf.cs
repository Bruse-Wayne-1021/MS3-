using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class gf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7abb5247-0e9b-4ee8-b994-49672600b93c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("a3b56432-87e5-4588-92d3-8cf153de8fc7"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b8418e1e-0f5f-4b5f-b547-68a92ef99da5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("645a938d-059a-4494-a3dc-9b980e8fcb2f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("c158ec16-79e6-407a-ad0b-605609ea8623"));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("03b1581c-9a1d-45b8-9841-959df1081908"), "Non Fiction", "Non-fictional content" },
                    { new Guid("05a17e9d-6c26-4a3b-a58d-c14b2893578e"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("05b552ea-4bf0-458f-8be5-ab9be65883e4"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("0c734833-bb0e-4906-bb02-3f8bc2ea9666"), "True Crime", "Real-life crime stories" },
                    { new Guid("28e0224a-7e4c-41ba-b019-475a395b7c6f"), "Biography", "Life stories of individuals" },
                    { new Guid("45d406b0-60f6-4b94-9ab4-ac4ae3233c29"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("605357a6-2c85-4fda-af14-9472ed236e72"), "Thriller", "Thrilling stories" },
                    { new Guid("613344bf-ae47-4b8e-b193-be92450074c4"), "Humor", "Funny and comedic stories" },
                    { new Guid("679e4805-05dc-467b-90d4-44efd18595d9"), "Romance Novel", "Romantic tales" },
                    { new Guid("7bc175f8-4577-4998-8154-c3422f6fd5e6"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("aecd14bf-fdae-4093-9392-4ae1deea1315"), "Fiction", "Fictional stories" },
                    { new Guid("da14951c-30d2-425f-8143-6e88c7024c98"), "Mystery", "Mystery novels" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("33109460-fbd0-451b-9aa0-27b98eaab0d2"), "Tamil" },
                    { new Guid("a4b1ae87-e2c2-47c4-acde-f54dbe9d48c7"), "English" },
                    { new Guid("f5a5832b-2ec2-4624-8ad1-65b04f184b4c"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("41620864-952c-4cf3-978a-851882bf4d0c"), "Admin" },
                    { new Guid("88d67a21-49cc-48a0-8c1d-b88c3590d0ee"), "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("03b1581c-9a1d-45b8-9841-959df1081908"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("05a17e9d-6c26-4a3b-a58d-c14b2893578e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("05b552ea-4bf0-458f-8be5-ab9be65883e4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("0c734833-bb0e-4906-bb02-3f8bc2ea9666"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("28e0224a-7e4c-41ba-b019-475a395b7c6f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("45d406b0-60f6-4b94-9ab4-ac4ae3233c29"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("605357a6-2c85-4fda-af14-9472ed236e72"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("613344bf-ae47-4b8e-b193-be92450074c4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("679e4805-05dc-467b-90d4-44efd18595d9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("7bc175f8-4577-4998-8154-c3422f6fd5e6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("aecd14bf-fdae-4093-9392-4ae1deea1315"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("da14951c-30d2-425f-8143-6e88c7024c98"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("33109460-fbd0-451b-9aa0-27b98eaab0d2"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("a4b1ae87-e2c2-47c4-acde-f54dbe9d48c7"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f5a5832b-2ec2-4624-8ad1-65b04f184b4c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("41620864-952c-4cf3-978a-851882bf4d0c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("88d67a21-49cc-48a0-8c1d-b88c3590d0ee"));

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("7abb5247-0e9b-4ee8-b994-49672600b93c"), "English" },
                    { new Guid("a3b56432-87e5-4588-92d3-8cf153de8fc7"), "Tamil" },
                    { new Guid("b8418e1e-0f5f-4b5f-b547-68a92ef99da5"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("645a938d-059a-4494-a3dc-9b980e8fcb2f"), "Member" },
                    { new Guid("c158ec16-79e6-407a-ad0b-605609ea8623"), "Admin" }
                });
        }
    }
}
