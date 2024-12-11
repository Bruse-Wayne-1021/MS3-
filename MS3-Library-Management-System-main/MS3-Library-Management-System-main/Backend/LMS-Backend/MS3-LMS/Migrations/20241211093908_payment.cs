using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class payment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("05a8049d-2754-4cc2-9633-c650ece1e3fa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("40a09432-0380-4ccf-9a52-cf193350f50c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("41bd7cb6-c51f-4c2a-bf62-742ef4cb87ed"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4f114fe6-770e-48c9-afa5-030ce826b7f1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("60b0d928-cd5e-47b0-b0e0-3c96abfcd2fc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("6f403ff5-4aa5-4a9f-8297-b07aaa331401"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("86d0a4e9-c794-47dc-8acd-57b0d2499d42"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("8baf8281-ccdd-4811-9f09-06e2408ff164"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("b00e5605-e4e0-4b78-9012-20ef3660cb4c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("bd0f8b82-664a-4825-b440-495f47c6a694"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d2873638-cfc9-4e51-a6d3-772e4e1f2d25"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e5149ca3-136a-4ac3-9743-cbac7185111f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("714da737-2b5f-4da4-a1b7-da69585040ee"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c0aa0b76-6144-4c71-8402-fb8ab6dd4219"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f6fb870d-9527-462c-89a8-d9f8a62b2057"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("1751a225-8149-4aa7-9d53-971bd4e73b2c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("49186f2c-d1dc-4e0d-be79-8d6589340ec6"));

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Payments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("04d75ee2-2f4f-470f-aeed-51c662b5bebc"), "Romance Novel", "Romantic tales" },
                    { new Guid("05bd1009-12cd-4d0f-bca3-91d5ef43b909"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("161f8380-1ad0-4529-bf73-fb2e0949cb88"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("20d22be3-4b2c-4449-909e-0af4b679b1c2"), "Mystery", "Mystery novels" },
                    { new Guid("294884c9-cb15-4057-914c-a7e2b07bf43b"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("34095ac9-6732-48f6-8e8a-f2aa6e1cbf59"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("45fe7d62-56f4-409d-b63a-da19b647552f"), "Biography", "Life stories of individuals" },
                    { new Guid("4a7fec4b-5ce9-4415-87e8-3925d05509ae"), "Fiction", "Fictional stories" },
                    { new Guid("4de8001b-d4f2-4c49-965b-72a502d8a09e"), "Thriller", "Thrilling stories" },
                    { new Guid("76f55b03-f4c1-4336-aa83-904bc52fd862"), "Non Fiction", "Non-fictional content" },
                    { new Guid("9e700cf0-76c6-47b7-a2f7-09ecb60fa5bd"), "True Crime", "Real-life crime stories" },
                    { new Guid("9f62e35c-2102-4b1a-8ea2-9cb5d2b2c5e1"), "Humor", "Funny and comedic stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("b17e2a5e-9081-4a7b-b166-c53bb94bc4dd"), "Singala" },
                    { new Guid("b1ce74b6-284a-45eb-9670-b048e6fa4e49"), "English" },
                    { new Guid("d68bf5fa-d00b-43d8-b1de-093b18505595"), "Tamil" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("a89edcfd-c6ba-4cf7-a9f7-e9cc4ef4f03d"), "Member" },
                    { new Guid("ca91eab2-cdfa-4fb9-a6b2-b00d180f3c75"), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("04d75ee2-2f4f-470f-aeed-51c662b5bebc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("05bd1009-12cd-4d0f-bca3-91d5ef43b909"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("161f8380-1ad0-4529-bf73-fb2e0949cb88"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("20d22be3-4b2c-4449-909e-0af4b679b1c2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("294884c9-cb15-4057-914c-a7e2b07bf43b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("34095ac9-6732-48f6-8e8a-f2aa6e1cbf59"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("45fe7d62-56f4-409d-b63a-da19b647552f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4a7fec4b-5ce9-4415-87e8-3925d05509ae"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4de8001b-d4f2-4c49-965b-72a502d8a09e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("76f55b03-f4c1-4336-aa83-904bc52fd862"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9e700cf0-76c6-47b7-a2f7-09ecb60fa5bd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9f62e35c-2102-4b1a-8ea2-9cb5d2b2c5e1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b17e2a5e-9081-4a7b-b166-c53bb94bc4dd"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b1ce74b6-284a-45eb-9670-b048e6fa4e49"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d68bf5fa-d00b-43d8-b1de-093b18505595"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("a89edcfd-c6ba-4cf7-a9f7-e9cc4ef4f03d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("ca91eab2-cdfa-4fb9-a6b2-b00d180f3c75"));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("05a8049d-2754-4cc2-9633-c650ece1e3fa"), "Romance Novel", "Romantic tales" },
                    { new Guid("40a09432-0380-4ccf-9a52-cf193350f50c"), "Non Fiction", "Non-fictional content" },
                    { new Guid("41bd7cb6-c51f-4c2a-bf62-742ef4cb87ed"), "Fiction", "Fictional stories" },
                    { new Guid("4f114fe6-770e-48c9-afa5-030ce826b7f1"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("60b0d928-cd5e-47b0-b0e0-3c96abfcd2fc"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("6f403ff5-4aa5-4a9f-8297-b07aaa331401"), "Thriller", "Thrilling stories" },
                    { new Guid("86d0a4e9-c794-47dc-8acd-57b0d2499d42"), "Biography", "Life stories of individuals" },
                    { new Guid("8baf8281-ccdd-4811-9f09-06e2408ff164"), "Humor", "Funny and comedic stories" },
                    { new Guid("b00e5605-e4e0-4b78-9012-20ef3660cb4c"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("bd0f8b82-664a-4825-b440-495f47c6a694"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("d2873638-cfc9-4e51-a6d3-772e4e1f2d25"), "True Crime", "Real-life crime stories" },
                    { new Guid("e5149ca3-136a-4ac3-9743-cbac7185111f"), "Mystery", "Mystery novels" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("714da737-2b5f-4da4-a1b7-da69585040ee"), "English" },
                    { new Guid("c0aa0b76-6144-4c71-8402-fb8ab6dd4219"), "Singala" },
                    { new Guid("f6fb870d-9527-462c-89a8-d9f8a62b2057"), "Tamil" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("1751a225-8149-4aa7-9d53-971bd4e73b2c"), "Member" },
                    { new Guid("49186f2c-d1dc-4e0d-be79-8d6589340ec6"), "Admin" }
                });
        }
    }
}
