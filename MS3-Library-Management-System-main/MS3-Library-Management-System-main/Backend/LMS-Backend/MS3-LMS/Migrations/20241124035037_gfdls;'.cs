using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class gfdls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("03f4e6f8-4614-4518-b67f-c9809b974484"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("38e446c9-871b-40bc-851e-1ecfa3cf1c7d"), "Humor", "Funny and comedic stories" },
                    { new Guid("57234aae-b51b-4c41-b3a3-7f1bf3604da2"), "True Crime", "Real-life crime stories" },
                    { new Guid("62da66b0-f180-49ec-8297-5128404c0430"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("656f62f9-128e-43d4-9216-ef202e92b556"), "Thriller", "Thrilling stories" },
                    { new Guid("65e520d0-19cb-41d1-b678-9cb3d7b93b82"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("8dc68f63-01e8-45a9-a151-40c692cf9f8a"), "Fiction", "Fictional stories" },
                    { new Guid("a329e607-3734-496c-a8d2-5856c4eaa8d2"), "Romance Novel", "Romantic tales" },
                    { new Guid("a83af87d-d138-4d9f-aaed-d91970e05858"), "Mystery", "Mystery novels" },
                    { new Guid("af1cd0bc-90db-4f32-9f79-efa2503a417c"), "Biography", "Life stories of individuals" },
                    { new Guid("e919d6e7-06b5-4c70-96e3-c4cf7a6977dc"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("f2dc42e5-bb99-4e36-9eec-0d72d896a9d6"), "Non Fiction", "Non-fictional content" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("116b2190-d970-4473-80e3-1366b34eaaff"), "English" },
                    { new Guid("4808d238-be15-41a2-b084-e44678814fd3"), "Tamil" },
                    { new Guid("5d34d9a7-93ff-4c27-862b-acb59100cc19"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("0a7e65ce-1a16-42d6-b1eb-9772aae5a2bc"), "Member" },
                    { new Guid("1d4d9918-736c-4a0b-87de-4fdaddaf2af8"), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("03f4e6f8-4614-4518-b67f-c9809b974484"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("38e446c9-871b-40bc-851e-1ecfa3cf1c7d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("57234aae-b51b-4c41-b3a3-7f1bf3604da2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("62da66b0-f180-49ec-8297-5128404c0430"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("656f62f9-128e-43d4-9216-ef202e92b556"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("65e520d0-19cb-41d1-b678-9cb3d7b93b82"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("8dc68f63-01e8-45a9-a151-40c692cf9f8a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a329e607-3734-496c-a8d2-5856c4eaa8d2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a83af87d-d138-4d9f-aaed-d91970e05858"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("af1cd0bc-90db-4f32-9f79-efa2503a417c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e919d6e7-06b5-4c70-96e3-c4cf7a6977dc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f2dc42e5-bb99-4e36-9eec-0d72d896a9d6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("116b2190-d970-4473-80e3-1366b34eaaff"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4808d238-be15-41a2-b084-e44678814fd3"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("5d34d9a7-93ff-4c27-862b-acb59100cc19"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("0a7e65ce-1a16-42d6-b1eb-9772aae5a2bc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("1d4d9918-736c-4a0b-87de-4fdaddaf2af8"));

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
    }
}
