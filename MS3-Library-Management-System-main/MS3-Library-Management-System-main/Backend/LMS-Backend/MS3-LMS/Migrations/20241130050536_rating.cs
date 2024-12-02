using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class rating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("198e635f-da2b-4c6f-9f14-cb9a462b7e30"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("3fc2d6d3-41a4-45da-aa8e-d646dab96b8e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("40d724d0-82ce-4657-af04-d55bfd760712"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("7a6a12bc-c402-4347-905c-3bb7957dc3ec"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("7a733d6d-c65a-4daf-aee6-a67c8b9c3a7b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a8cdb79d-754f-47af-87d1-da2fd64d1e97"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ab3d50cc-4a78-430f-8e20-40691ed9329b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("b44caf72-f3d1-4bf7-9b34-e113f81a92c8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("c41f1180-fb34-40c0-ad3e-469dbf23e1ec"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("c7adc191-b4ba-4928-a2c4-fc3988df086e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("db4f4422-a5a5-4063-84d6-55bc062fcec1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("fca60d74-ccb9-42d0-b26a-93e48ac5bc87"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("376983c7-eb20-4ab1-92e4-982104d8a41c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("5def37d5-8583-4980-9e4b-45c56b492589"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("fc3e2882-e849-498b-a510-807fbee4018c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("03ec50ca-72e6-4880-9d87-d6ccb3574fdd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("aaed3ac2-fc66-4456-9492-5dc8c1c54bbe"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("198e635f-da2b-4c6f-9f14-cb9a462b7e30"), "Thriller", "Thrilling stories" },
                    { new Guid("3fc2d6d3-41a4-45da-aa8e-d646dab96b8e"), "Mystery", "Mystery novels" },
                    { new Guid("40d724d0-82ce-4657-af04-d55bfd760712"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("7a6a12bc-c402-4347-905c-3bb7957dc3ec"), "Non Fiction", "Non-fictional content" },
                    { new Guid("7a733d6d-c65a-4daf-aee6-a67c8b9c3a7b"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("a8cdb79d-754f-47af-87d1-da2fd64d1e97"), "Biography", "Life stories of individuals" },
                    { new Guid("ab3d50cc-4a78-430f-8e20-40691ed9329b"), "True Crime", "Real-life crime stories" },
                    { new Guid("b44caf72-f3d1-4bf7-9b34-e113f81a92c8"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("c41f1180-fb34-40c0-ad3e-469dbf23e1ec"), "Romance Novel", "Romantic tales" },
                    { new Guid("c7adc191-b4ba-4928-a2c4-fc3988df086e"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("db4f4422-a5a5-4063-84d6-55bc062fcec1"), "Fiction", "Fictional stories" },
                    { new Guid("fca60d74-ccb9-42d0-b26a-93e48ac5bc87"), "Humor", "Funny and comedic stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("376983c7-eb20-4ab1-92e4-982104d8a41c"), "English" },
                    { new Guid("5def37d5-8583-4980-9e4b-45c56b492589"), "Tamil" },
                    { new Guid("fc3e2882-e849-498b-a510-807fbee4018c"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("03ec50ca-72e6-4880-9d87-d6ccb3574fdd"), "Admin" },
                    { new Guid("aaed3ac2-fc66-4456-9492-5dc8c1c54bbe"), "Member" }
                });
        }
    }
}
