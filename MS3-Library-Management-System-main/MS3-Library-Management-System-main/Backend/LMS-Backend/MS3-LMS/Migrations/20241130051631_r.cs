using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class r : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("21a5e81c-bdab-442f-ace9-fbbb9dbbcabf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4e046214-f7f0-4e88-ad9b-e38bf93d73f3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("51496588-cfc9-43e7-bae8-506e24a60e72"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("53acdf02-b38f-4a22-8c07-bfff2786b428"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("746dcda6-884a-4839-a003-fdb4d851db7a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("779d9b6a-1243-4dbe-bdc8-01e6d87c3975"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("7eaba18d-7d9d-414d-b36b-ea11c1992793"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9adcbde6-60d9-48ff-ad5e-e285c673dd33"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("b8b20a9b-ccb6-4fbe-99d0-f5e539ad22af"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e0d063a0-243e-4b5c-ae76-c37cfbae7c40"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e3ac0985-d24e-4579-9536-1713cdb894c7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f41f00ec-a132-4923-8b28-685f19422439"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("00b8b685-4b68-4469-a523-d3b25b574da6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("6cf3125e-2859-4a7b-8691-04a43e627ab7"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("9c6d89b6-6b64-4439-86fc-8c6127bdd1f5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("bf28158b-c8ce-496a-99b4-4d8b217f4469"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("d6c9241f-77f4-49ab-9dc0-d2901986f90d"));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("33559b9b-f2dd-4022-b94b-92a8d23e79a0"), "Mystery", "Mystery novels" },
                    { new Guid("4f37586b-4e33-4bf0-8350-d675b78afdd4"), "Humor", "Funny and comedic stories" },
                    { new Guid("88b94d77-4e89-4396-9931-542ca3219518"), "Biography", "Life stories of individuals" },
                    { new Guid("9a9855ff-213f-4787-835a-d6ed6c56016c"), "Fiction", "Fictional stories" },
                    { new Guid("a71216cb-75dc-439a-acc5-80d90aadda20"), "Thriller", "Thrilling stories" },
                    { new Guid("ba367de3-b0e3-4ca5-9c47-0add9c4a4d00"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("be577821-ca2a-47bc-b8b6-520eee5654b9"), "Non Fiction", "Non-fictional content" },
                    { new Guid("c941ed7e-9498-4bfb-9b0b-63a50c82e064"), "Romance Novel", "Romantic tales" },
                    { new Guid("d888d035-1b3b-4747-b195-3b6ceb0d4d3f"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("e8761bef-92f4-48e9-b01c-857d7f6f7024"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("ecbaa870-5711-41da-9e5f-e0ac295be56b"), "True Crime", "Real-life crime stories" },
                    { new Guid("ecec1173-44bf-4f57-a346-6189434d5f76"), "Magical Realism", "Stories blending magic and realism" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("7418c30b-d8b2-40cf-ad3c-f0e2ed7872aa"), "Singalam" },
                    { new Guid("7c195ef6-0fd5-4d41-9857-57e01137f150"), "Tamil" },
                    { new Guid("a4a135ef-207d-4835-a632-ad173c703af7"), "English" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("00646c7b-7315-4a8e-8e3e-01ef01ae3c44"), "Admin" },
                    { new Guid("43e033cd-9d2a-401b-998a-83de6c6989e0"), "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("33559b9b-f2dd-4022-b94b-92a8d23e79a0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4f37586b-4e33-4bf0-8350-d675b78afdd4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("88b94d77-4e89-4396-9931-542ca3219518"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9a9855ff-213f-4787-835a-d6ed6c56016c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a71216cb-75dc-439a-acc5-80d90aadda20"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ba367de3-b0e3-4ca5-9c47-0add9c4a4d00"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("be577821-ca2a-47bc-b8b6-520eee5654b9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("c941ed7e-9498-4bfb-9b0b-63a50c82e064"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d888d035-1b3b-4747-b195-3b6ceb0d4d3f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e8761bef-92f4-48e9-b01c-857d7f6f7024"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ecbaa870-5711-41da-9e5f-e0ac295be56b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ecec1173-44bf-4f57-a346-6189434d5f76"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7418c30b-d8b2-40cf-ad3c-f0e2ed7872aa"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7c195ef6-0fd5-4d41-9857-57e01137f150"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("a4a135ef-207d-4835-a632-ad173c703af7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("00646c7b-7315-4a8e-8e3e-01ef01ae3c44"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("43e033cd-9d2a-401b-998a-83de6c6989e0"));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("21a5e81c-bdab-442f-ace9-fbbb9dbbcabf"), "Biography", "Life stories of individuals" },
                    { new Guid("4e046214-f7f0-4e88-ad9b-e38bf93d73f3"), "Thriller", "Thrilling stories" },
                    { new Guid("51496588-cfc9-43e7-bae8-506e24a60e72"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("53acdf02-b38f-4a22-8c07-bfff2786b428"), "Mystery", "Mystery novels" },
                    { new Guid("746dcda6-884a-4839-a003-fdb4d851db7a"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("779d9b6a-1243-4dbe-bdc8-01e6d87c3975"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("7eaba18d-7d9d-414d-b36b-ea11c1992793"), "True Crime", "Real-life crime stories" },
                    { new Guid("9adcbde6-60d9-48ff-ad5e-e285c673dd33"), "Romance Novel", "Romantic tales" },
                    { new Guid("b8b20a9b-ccb6-4fbe-99d0-f5e539ad22af"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("e0d063a0-243e-4b5c-ae76-c37cfbae7c40"), "Non Fiction", "Non-fictional content" },
                    { new Guid("e3ac0985-d24e-4579-9536-1713cdb894c7"), "Humor", "Funny and comedic stories" },
                    { new Guid("f41f00ec-a132-4923-8b28-685f19422439"), "Fiction", "Fictional stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("00b8b685-4b68-4469-a523-d3b25b574da6"), "Singalam" },
                    { new Guid("6cf3125e-2859-4a7b-8691-04a43e627ab7"), "English" },
                    { new Guid("9c6d89b6-6b64-4439-86fc-8c6127bdd1f5"), "Tamil" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("bf28158b-c8ce-496a-99b4-4d8b217f4469"), "Member" },
                    { new Guid("d6c9241f-77f4-49ab-9dc0-d2901986f90d"), "Admin" }
                });
        }
    }
}
