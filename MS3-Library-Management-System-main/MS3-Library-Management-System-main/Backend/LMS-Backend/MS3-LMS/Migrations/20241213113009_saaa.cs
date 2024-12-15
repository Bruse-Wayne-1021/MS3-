using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class saaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<bool>(
                name: "IsConfirmEmail",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<bool>(
                name: "IsConfirmEmail",
                table: "Users",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

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
    }
}
