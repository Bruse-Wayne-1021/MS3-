using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class saji : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("0b75c448-b97e-40ec-bd72-e5571f085e7d"), "Admin" },
                    { new Guid("87ca4ff1-6c2b-4b9d-bd49-7d048e7d6397"), "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("0b75c448-b97e-40ec-bd72-e5571f085e7d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("87ca4ff1-6c2b-4b9d-bd49-7d048e7d6397"));

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
    }
}
