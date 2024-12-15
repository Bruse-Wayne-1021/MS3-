using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("0198602c-9364-4664-9a93-c8dbf8fd4b11"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("127f2fe4-1a82-4183-8ed8-e300b1c1352c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("153c9e63-6f6a-4202-a7ba-44c8692eb200"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("23ad1bfe-60c8-4ecb-be26-4cf6e1c5b774"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("5c6a8065-84a8-4ef1-9f0b-2b1de9690150"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("6279c903-8a78-47e6-8adf-ede5a9585c8f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("6496d541-6ad8-434c-88d7-369b87a0dd8d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("944397b0-a07b-4fa0-9ff2-aa2ef2e00579"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("98c6b683-1f53-40f6-9711-1a974baa5f52"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d63857c1-c5b0-48b7-a958-16ee6545baa7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d99be70a-4568-4af0-abd8-641ba5b47da6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f97218e7-a935-49a2-b1a6-aa4946cc79ad"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("997d7dcf-81ec-4697-9a54-3eda467cada5"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b8a48376-b134-44bb-a1b1-5b556aceec97"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f28af281-eca4-44dd-b99c-a95e62cc5436"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("c69fbafc-3ac8-461e-b876-89132e255246"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("edd673af-0efc-44fe-a0c8-e759cc41b121"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("0198602c-9364-4664-9a93-c8dbf8fd4b11"), "Humor", "Funny and comedic stories" },
                    { new Guid("127f2fe4-1a82-4183-8ed8-e300b1c1352c"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("153c9e63-6f6a-4202-a7ba-44c8692eb200"), "Mystery", "Mystery novels" },
                    { new Guid("23ad1bfe-60c8-4ecb-be26-4cf6e1c5b774"), "Thriller", "Thrilling stories" },
                    { new Guid("5c6a8065-84a8-4ef1-9f0b-2b1de9690150"), "True Crime", "Real-life crime stories" },
                    { new Guid("6279c903-8a78-47e6-8adf-ede5a9585c8f"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("6496d541-6ad8-434c-88d7-369b87a0dd8d"), "Non Fiction", "Non-fictional content" },
                    { new Guid("944397b0-a07b-4fa0-9ff2-aa2ef2e00579"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("98c6b683-1f53-40f6-9711-1a974baa5f52"), "Romance Novel", "Romantic tales" },
                    { new Guid("d63857c1-c5b0-48b7-a958-16ee6545baa7"), "Biography", "Life stories of individuals" },
                    { new Guid("d99be70a-4568-4af0-abd8-641ba5b47da6"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("f97218e7-a935-49a2-b1a6-aa4946cc79ad"), "Fiction", "Fictional stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("997d7dcf-81ec-4697-9a54-3eda467cada5"), "Tamil" },
                    { new Guid("b8a48376-b134-44bb-a1b1-5b556aceec97"), "English" },
                    { new Guid("f28af281-eca4-44dd-b99c-a95e62cc5436"), "Singala" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("c69fbafc-3ac8-461e-b876-89132e255246"), "Admin" },
                    { new Guid("edd673af-0efc-44fe-a0c8-e759cc41b121"), "Member" }
                });
        }
    }
}
