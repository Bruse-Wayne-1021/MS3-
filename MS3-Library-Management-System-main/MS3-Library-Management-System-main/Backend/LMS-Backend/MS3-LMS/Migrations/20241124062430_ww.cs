using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class ww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("0b75c448-b97e-40ec-bd72-e5571f085e7d"), "Admin" },
                    { new Guid("87ca4ff1-6c2b-4b9d-bd49-7d048e7d6397"), "Member" }
                });
        }
    }
}
