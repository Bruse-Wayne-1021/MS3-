using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class register : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Members",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Members",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
