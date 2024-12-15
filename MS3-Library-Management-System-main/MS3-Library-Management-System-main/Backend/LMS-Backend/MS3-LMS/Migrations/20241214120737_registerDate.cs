using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class registerDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("05dd32d6-48a4-4c03-b842-f456a83c2c6d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("164d21ee-8bb6-4aa6-a3cf-80058d7885a6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("1dff11bd-d656-4471-a793-31694a962cc1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("2f1bb645-62f0-4fb0-bed2-e57146c948e5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("3fd687c2-33f7-4bb0-9091-f5a6cf7fadf6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("7c1854e2-d122-49dc-b853-1d4ead61a4b7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("c0b4d23e-fae4-4fad-856c-02a8a44f1d54"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d7ab999e-18ff-416f-a846-f8da908aed8c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("dbdaabed-f2c0-4435-bef3-82c14e1a7782"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("dbfd4f20-96ab-4628-9481-3b02fc10a7a8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("fa6236e5-299b-4ac7-8304-ac3fdf049253"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("fdbc69da-ae21-4e57-906d-31f04bd5e792"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("59387b99-0c67-4545-b035-d3bf427912c6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8bf20707-3a95-40f6-989e-e1ccced664f8"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ccc5bc29-f3ca-46d7-8ef0-5f919d2609ec"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("5288926a-e074-467a-8950-ff28b46a680e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("a4c03239-1ee4-4d0c-986c-999ed6afc1a4"));

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterDate",
                table: "Members",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("0879af90-96dc-43ed-b0bb-ee22ebe2548a"), "Fiction", "Fictional stories" },
                    { new Guid("08f5d4d7-542b-422f-b06a-9943b04e3067"), "Romance Novel", "Romantic tales" },
                    { new Guid("13fe2e0b-5afc-4952-8f4f-025c5e48b9d6"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("355ac982-99ea-46e7-8309-ebca859a75bb"), "Non Fiction", "Non-fictional content" },
                    { new Guid("38d89ef4-a69a-4962-9ca2-f56c028d7051"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("5f36921d-2ddf-446d-b0de-3585a2e1d753"), "Humor", "Funny and comedic stories" },
                    { new Guid("85340ec8-1ffd-4abb-89d5-e7ac22b67e4b"), "Biography", "Life stories of individuals" },
                    { new Guid("a88f7d9d-0a41-48e6-88c4-28c500e9752a"), "True Crime", "Real-life crime stories" },
                    { new Guid("b69c78ea-2a97-4842-9c77-5805a3981485"), "Mystery", "Mystery novels" },
                    { new Guid("e8e8603c-ff0a-48a4-8c54-e2ea43c5044a"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("ec3cc5be-72bf-40ab-86a5-d80aecf5ce53"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("ffc9a985-f6d3-4af3-aebf-b3c8f171a40f"), "Thriller", "Thrilling stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("32841a72-6a4e-4d70-adde-637221720b3b"), "Singala" },
                    { new Guid("9200ef49-e412-4a5c-a588-84abf8c2febf"), "English" },
                    { new Guid("e86e5dbc-d626-43dc-bfe3-f13514654313"), "Tamil" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("21d25b4d-f455-441c-b2e6-3faf049d2b5e"), "Admin" },
                    { new Guid("ba3c9bef-b006-4802-ba7d-5b89c9472726"), "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("0879af90-96dc-43ed-b0bb-ee22ebe2548a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("08f5d4d7-542b-422f-b06a-9943b04e3067"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("13fe2e0b-5afc-4952-8f4f-025c5e48b9d6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("355ac982-99ea-46e7-8309-ebca859a75bb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("38d89ef4-a69a-4962-9ca2-f56c028d7051"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("5f36921d-2ddf-446d-b0de-3585a2e1d753"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("85340ec8-1ffd-4abb-89d5-e7ac22b67e4b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a88f7d9d-0a41-48e6-88c4-28c500e9752a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("b69c78ea-2a97-4842-9c77-5805a3981485"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e8e8603c-ff0a-48a4-8c54-e2ea43c5044a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ec3cc5be-72bf-40ab-86a5-d80aecf5ce53"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ffc9a985-f6d3-4af3-aebf-b3c8f171a40f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("32841a72-6a4e-4d70-adde-637221720b3b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("9200ef49-e412-4a5c-a588-84abf8c2febf"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e86e5dbc-d626-43dc-bfe3-f13514654313"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("21d25b4d-f455-441c-b2e6-3faf049d2b5e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("ba3c9bef-b006-4802-ba7d-5b89c9472726"));

            migrationBuilder.DropColumn(
                name: "RegisterDate",
                table: "Members");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("05dd32d6-48a4-4c03-b842-f456a83c2c6d"), "True Crime", "Real-life crime stories" },
                    { new Guid("164d21ee-8bb6-4aa6-a3cf-80058d7885a6"), "Mystery", "Mystery novels" },
                    { new Guid("1dff11bd-d656-4471-a793-31694a962cc1"), "Non Fiction", "Non-fictional content" },
                    { new Guid("2f1bb645-62f0-4fb0-bed2-e57146c948e5"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("3fd687c2-33f7-4bb0-9091-f5a6cf7fadf6"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("7c1854e2-d122-49dc-b853-1d4ead61a4b7"), "Fiction", "Fictional stories" },
                    { new Guid("c0b4d23e-fae4-4fad-856c-02a8a44f1d54"), "Romance Novel", "Romantic tales" },
                    { new Guid("d7ab999e-18ff-416f-a846-f8da908aed8c"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("dbdaabed-f2c0-4435-bef3-82c14e1a7782"), "Biography", "Life stories of individuals" },
                    { new Guid("dbfd4f20-96ab-4628-9481-3b02fc10a7a8"), "Thriller", "Thrilling stories" },
                    { new Guid("fa6236e5-299b-4ac7-8304-ac3fdf049253"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("fdbc69da-ae21-4e57-906d-31f04bd5e792"), "Humor", "Funny and comedic stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("59387b99-0c67-4545-b035-d3bf427912c6"), "Singala" },
                    { new Guid("8bf20707-3a95-40f6-989e-e1ccced664f8"), "English" },
                    { new Guid("ccc5bc29-f3ca-46d7-8ef0-5f919d2609ec"), "Tamil" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("5288926a-e074-467a-8950-ff28b46a680e"), "Member" },
                    { new Guid("a4c03239-1ee4-4d0c-986c-999ed6afc1a4"), "Admin" }
                });
        }
    }
}
