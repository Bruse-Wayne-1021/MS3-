using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("114135a4-8115-4e72-9761-a56387f951b5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("2f5b7c91-dbb1-4f6d-b4c8-8f805038054f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("65474f5f-9ede-4e05-80ee-1502b83f1dc9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("8f221132-14c3-463e-afb3-89a39a1ed0f7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a155df58-f467-4b34-ab9d-370b6c115153"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ac53359c-b776-4462-a196-bb3ec6dd5a94"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("acc2dd09-b8f0-4c61-9b14-06e7b87723ec"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("b04b69b9-5770-4a61-81a9-c1113e664253"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("c88c8b3c-d99c-4ffa-871a-2d049998fede"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e846534d-4cd4-4b98-b2d3-24f276e0008a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f5e5caeb-5fe2-44de-9a60-0363914bf9d7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("fa061d4e-7c72-410f-9238-f29d67784453"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("6dbf3951-20c2-42eb-84df-5a2df4c2e388"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b4757908-78ce-4457-a465-ea7c9deaaa74"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b662876f-1107-4e5e-97e1-bcf8a4d69660"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("1a49253f-30eb-4110-ab47-34fa545c3ea1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("82f9e08e-af04-427c-8e05-263a8604e6bd"));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("27beed79-31f7-430a-8616-2226878b539b"), "Non Fiction", "Non-fictional content" },
                    { new Guid("36bb0a88-105b-46f9-93d5-600df1d15cb5"), "Humor", "Funny and comedic stories" },
                    { new Guid("40cb1813-c0b3-49b6-9d17-e2e664dca831"), "Fiction", "Fictional stories" },
                    { new Guid("5394cb99-0edd-4024-8b7f-4c54c6b0133c"), "Romance Novel", "Romantic tales" },
                    { new Guid("670bc5e3-c9b4-4d2d-8502-807616cc406c"), "True Crime", "Real-life crime stories" },
                    { new Guid("7762ad72-dd33-4d71-ac9d-eedb339399aa"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("89c1bd30-a63f-471f-8c6a-aeba7d2e230e"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("d383566a-6b12-49d2-ba9b-a7d9f4bea8f0"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("d4b7cdb9-7184-4f38-a715-35fd4e487479"), "Biography", "Life stories of individuals" },
                    { new Guid("e373b18f-081b-497c-ad1e-889f3c202484"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("eae049e0-ce65-4d5e-8c4a-e9bdb4521383"), "Mystery", "Mystery novels" },
                    { new Guid("ef6798d5-9f03-4689-a4b1-3f0e19cf02cf"), "Thriller", "Thrilling stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("0af3c165-9359-43aa-9faa-cd9e95b305af"), "Singala" },
                    { new Guid("e00485ee-3045-4f0a-b95a-45197e48739b"), "English" },
                    { new Guid("e75223ef-42c1-47d1-bf2f-f1765d600470"), "Tamil" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("46d171df-34fe-4875-9d2c-ec7d4dc5afc5"), "Member" },
                    { new Guid("50623b8a-ddd4-4939-8748-bd3cbb526f46"), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("27beed79-31f7-430a-8616-2226878b539b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("36bb0a88-105b-46f9-93d5-600df1d15cb5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("40cb1813-c0b3-49b6-9d17-e2e664dca831"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("5394cb99-0edd-4024-8b7f-4c54c6b0133c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("670bc5e3-c9b4-4d2d-8502-807616cc406c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("7762ad72-dd33-4d71-ac9d-eedb339399aa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("89c1bd30-a63f-471f-8c6a-aeba7d2e230e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d383566a-6b12-49d2-ba9b-a7d9f4bea8f0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d4b7cdb9-7184-4f38-a715-35fd4e487479"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e373b18f-081b-497c-ad1e-889f3c202484"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("eae049e0-ce65-4d5e-8c4a-e9bdb4521383"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ef6798d5-9f03-4689-a4b1-3f0e19cf02cf"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("0af3c165-9359-43aa-9faa-cd9e95b305af"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e00485ee-3045-4f0a-b95a-45197e48739b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e75223ef-42c1-47d1-bf2f-f1765d600470"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("46d171df-34fe-4875-9d2c-ec7d4dc5afc5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("50623b8a-ddd4-4939-8748-bd3cbb526f46"));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("114135a4-8115-4e72-9761-a56387f951b5"), "Fiction", "Fictional stories" },
                    { new Guid("2f5b7c91-dbb1-4f6d-b4c8-8f805038054f"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("65474f5f-9ede-4e05-80ee-1502b83f1dc9"), "Romance Novel", "Romantic tales" },
                    { new Guid("8f221132-14c3-463e-afb3-89a39a1ed0f7"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("a155df58-f467-4b34-ab9d-370b6c115153"), "Thriller", "Thrilling stories" },
                    { new Guid("ac53359c-b776-4462-a196-bb3ec6dd5a94"), "Humor", "Funny and comedic stories" },
                    { new Guid("acc2dd09-b8f0-4c61-9b14-06e7b87723ec"), "True Crime", "Real-life crime stories" },
                    { new Guid("b04b69b9-5770-4a61-81a9-c1113e664253"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("c88c8b3c-d99c-4ffa-871a-2d049998fede"), "Mystery", "Mystery novels" },
                    { new Guid("e846534d-4cd4-4b98-b2d3-24f276e0008a"), "Non Fiction", "Non-fictional content" },
                    { new Guid("f5e5caeb-5fe2-44de-9a60-0363914bf9d7"), "Biography", "Life stories of individuals" },
                    { new Guid("fa061d4e-7c72-410f-9238-f29d67784453"), "Graphic Novel", "Stories told through illustrations" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("6dbf3951-20c2-42eb-84df-5a2df4c2e388"), "Singala" },
                    { new Guid("b4757908-78ce-4457-a465-ea7c9deaaa74"), "Tamil" },
                    { new Guid("b662876f-1107-4e5e-97e1-bcf8a4d69660"), "English" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("1a49253f-30eb-4110-ab47-34fa545c3ea1"), "Admin" },
                    { new Guid("82f9e08e-af04-427c-8e05-263a8604e6bd"), "Member" }
                });
        }
    }
}
