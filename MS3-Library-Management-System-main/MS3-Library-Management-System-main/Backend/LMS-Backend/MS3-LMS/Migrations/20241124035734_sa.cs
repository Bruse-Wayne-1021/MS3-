using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class sa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0e9ff416-2224-4955-9775-014cee0e0ce8"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("31537a84-e1d7-4502-92bd-9f2d97da77df"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("3f168993-7242-4328-9926-122ef880f96d"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("55d8b93b-6a40-482f-b4f5-cb3eac3084ba"), "Mystery", "Mystery novels" },
                    { new Guid("5d007263-2aa7-47c0-9937-e3b33894626b"), "Non Fiction", "Non-fictional content" },
                    { new Guid("95bc47da-7f54-4456-acb0-4c72741a13db"), "True Crime", "Real-life crime stories" },
                    { new Guid("a1309a1b-3197-4198-9275-c565a6b244dd"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("a37b13a0-3d80-4e29-a973-3a618cb8c34b"), "Biography", "Life stories of individuals" },
                    { new Guid("a3a22915-2eba-437f-978e-52db8c59c09f"), "Thriller", "Thrilling stories" },
                    { new Guid("d2d984ca-e9e5-4f19-843a-af84038e478e"), "Fiction", "Fictional stories" },
                    { new Guid("ed5c61cb-ecc9-4f83-adc6-c417af283a75"), "Romance Novel", "Romantic tales" },
                    { new Guid("f1b8e840-6ef1-4df8-9a4d-53dab8466dcf"), "Humor", "Funny and comedic stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("21e7d543-5f89-447c-8bbe-c9e7fec4c09a"), "Tamil" },
                    { new Guid("53811111-1a00-4d66-9afb-dbe29da53890"), "English" },
                    { new Guid("6ee60eaa-7a4b-4880-8f84-0304e11b4eeb"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("ecbc1f34-a32a-44e5-acf5-ab883677dc6b"), "Member" },
                    { new Guid("f45a04ac-2950-48b0-8d30-7edd9c3c9ae7"), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("0e9ff416-2224-4955-9775-014cee0e0ce8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("31537a84-e1d7-4502-92bd-9f2d97da77df"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("3f168993-7242-4328-9926-122ef880f96d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("55d8b93b-6a40-482f-b4f5-cb3eac3084ba"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("5d007263-2aa7-47c0-9937-e3b33894626b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("95bc47da-7f54-4456-acb0-4c72741a13db"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a1309a1b-3197-4198-9275-c565a6b244dd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a37b13a0-3d80-4e29-a973-3a618cb8c34b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a3a22915-2eba-437f-978e-52db8c59c09f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d2d984ca-e9e5-4f19-843a-af84038e478e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ed5c61cb-ecc9-4f83-adc6-c417af283a75"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f1b8e840-6ef1-4df8-9a4d-53dab8466dcf"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("21e7d543-5f89-447c-8bbe-c9e7fec4c09a"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("53811111-1a00-4d66-9afb-dbe29da53890"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("6ee60eaa-7a4b-4880-8f84-0304e11b4eeb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("ecbc1f34-a32a-44e5-acf5-ab883677dc6b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("f45a04ac-2950-48b0-8d30-7edd9c3c9ae7"));

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
    }
}
