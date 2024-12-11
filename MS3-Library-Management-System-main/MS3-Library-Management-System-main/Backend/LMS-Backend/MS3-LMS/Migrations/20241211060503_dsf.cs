using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class dsf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("143996fc-21d6-4b2a-a07a-0b189fde6c28"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("1dce8475-b1eb-48cc-b906-060b1f7addbf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("3f49a318-9994-4952-9afc-327b4b31b65b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("42f983bc-08d2-4355-98bf-3a2d5fee60d1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("774b7a09-2db7-4c78-9a59-964274f2f31d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("997e4067-25c0-48d9-8ff5-b370f395c6ad"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("bbef9270-437b-430a-b02a-b1ae465cf188"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("cbdce5d9-d529-43db-9c1f-f5f28b1b5626"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ccbd020a-3f40-4e3c-b881-738f940532d0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d466c888-9639-440c-ba99-fa4f5f987b01"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e395f4a6-db7a-4c28-8d3f-8cd7482e0018"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e4f1f6a7-f3b3-471e-8b87-d48d19d75c3c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("1ac8e2b8-e2d5-4946-9478-aea7c47c6b5b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b4e96161-ef16-4cbd-b26a-6bd664815b88"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e2a077e4-0464-4a9b-9005-a9b8f46f9127"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("023172be-27b9-418a-bbf4-f079139cd484"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("787cb17e-c125-47d8-8225-86e75cb06b31"));

            migrationBuilder.DropColumn(
                name: "TextContent",
                table: "Books");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "TextContent",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("143996fc-21d6-4b2a-a07a-0b189fde6c28"), "Fiction", "Fictional stories" },
                    { new Guid("1dce8475-b1eb-48cc-b906-060b1f7addbf"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("3f49a318-9994-4952-9afc-327b4b31b65b"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("42f983bc-08d2-4355-98bf-3a2d5fee60d1"), "Humor", "Funny and comedic stories" },
                    { new Guid("774b7a09-2db7-4c78-9a59-964274f2f31d"), "Biography", "Life stories of individuals" },
                    { new Guid("997e4067-25c0-48d9-8ff5-b370f395c6ad"), "Romance Novel", "Romantic tales" },
                    { new Guid("bbef9270-437b-430a-b02a-b1ae465cf188"), "Thriller", "Thrilling stories" },
                    { new Guid("cbdce5d9-d529-43db-9c1f-f5f28b1b5626"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("ccbd020a-3f40-4e3c-b881-738f940532d0"), "Non Fiction", "Non-fictional content" },
                    { new Guid("d466c888-9639-440c-ba99-fa4f5f987b01"), "Mystery", "Mystery novels" },
                    { new Guid("e395f4a6-db7a-4c28-8d3f-8cd7482e0018"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("e4f1f6a7-f3b3-471e-8b87-d48d19d75c3c"), "True Crime", "Real-life crime stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("1ac8e2b8-e2d5-4946-9478-aea7c47c6b5b"), "Singala" },
                    { new Guid("b4e96161-ef16-4cbd-b26a-6bd664815b88"), "English" },
                    { new Guid("e2a077e4-0464-4a9b-9005-a9b8f46f9127"), "Tamil" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("023172be-27b9-418a-bbf4-f079139cd484"), "Admin" },
                    { new Guid("787cb17e-c125-47d8-8225-86e75cb06b31"), "Member" }
                });
        }
    }
}
