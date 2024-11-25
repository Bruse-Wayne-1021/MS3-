using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class @as : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("17ba0c77-1df9-49f5-9eac-eb3c0b9767cc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("52bd4afa-0b4d-43c9-a70a-461cf920d6d1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("6670b562-531f-48be-9032-e027af91747e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("6677f242-a735-4d37-806d-da527bd1d044"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9097c151-b7f1-42e4-8267-683a7fa4c2ae"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9a68befc-a406-443b-9574-212fb0170166"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("af16788e-5f6a-42bf-aac0-cd31974ecf0d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d603f587-7c10-43f2-b909-4dd027d16597"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("dedb047a-435e-47d2-91c3-0eb9719503e5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e7439ae8-8a44-4741-894f-ecc275031d62"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ea890917-edf8-4ac6-b067-1ae6c188a69f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f19dfb8d-4590-4fb0-8816-93b4aa0be5ef"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("3b58a031-657a-49f0-b217-6f262349c1e3"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4291b3eb-3729-43fd-9236-0c58f4426d13"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("5cf5f141-c734-40ee-b4fe-21c6622ccea2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("766957fe-1c28-4300-b615-af48e96b443f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("a20a25fc-3384-45f7-abf3-fe79844301cc"));

            migrationBuilder.DropColumn(
                name: "BookType",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Books");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "BookType",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("17ba0c77-1df9-49f5-9eac-eb3c0b9767cc"), "Thriller", "Thrilling stories" },
                    { new Guid("52bd4afa-0b4d-43c9-a70a-461cf920d6d1"), "Mystery", "Mystery novels" },
                    { new Guid("6670b562-531f-48be-9032-e027af91747e"), "Romance Novel", "Romantic tales" },
                    { new Guid("6677f242-a735-4d37-806d-da527bd1d044"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("9097c151-b7f1-42e4-8267-683a7fa4c2ae"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("9a68befc-a406-443b-9574-212fb0170166"), "Humor", "Funny and comedic stories" },
                    { new Guid("af16788e-5f6a-42bf-aac0-cd31974ecf0d"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("d603f587-7c10-43f2-b909-4dd027d16597"), "Non Fiction", "Non-fictional content" },
                    { new Guid("dedb047a-435e-47d2-91c3-0eb9719503e5"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("e7439ae8-8a44-4741-894f-ecc275031d62"), "True Crime", "Real-life crime stories" },
                    { new Guid("ea890917-edf8-4ac6-b067-1ae6c188a69f"), "Biography", "Life stories of individuals" },
                    { new Guid("f19dfb8d-4590-4fb0-8816-93b4aa0be5ef"), "Fiction", "Fictional stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("3b58a031-657a-49f0-b217-6f262349c1e3"), "English" },
                    { new Guid("4291b3eb-3729-43fd-9236-0c58f4426d13"), "Tamil" },
                    { new Guid("5cf5f141-c734-40ee-b4fe-21c6622ccea2"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("766957fe-1c28-4300-b615-af48e96b443f"), "Member" },
                    { new Guid("a20a25fc-3384-45f7-abf3-fe79844301cc"), "Admin" }
                });
        }
    }
}
