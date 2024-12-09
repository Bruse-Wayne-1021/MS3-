using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class booktype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("1621b0e9-5a63-4ceb-b910-e9e27b6a23ef"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("1c6e4e56-e189-4639-92bf-54853a0d91aa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("446c4173-7ada-4298-82f7-c1285f1659ff"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4b63d960-fa87-4b30-9eb2-0adc31e41127"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("581969bd-ea56-4b96-9368-f8466a88935b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("6532555c-d40e-4fd6-95cb-08c368281240"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("7039050c-9ca4-4cab-90ba-4362c7a6cec9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("81182548-48c7-445a-97ce-195d835e0eb2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d13289f4-5dd7-4b74-b675-69278a89478a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("de22de14-bfe4-4808-95c1-24ea032c5ebc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ea5c065b-91a5-4b73-b388-8fa614da261b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("edc4577d-1907-4a46-890b-30fa32e2d0e1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("541fc50f-cc7e-4178-8ddc-e20c620cc6d2"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("73226e67-486b-484b-9b93-df4405a8dd9f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c9c7c3f0-996d-49c5-9905-3d9174222a5a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("239d5ce1-16ad-4b7a-ad68-83f1f35def28"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("43b7d1be-799e-4f6c-ac50-eb7bcecb0eb0"));

            migrationBuilder.AddColumn<int>(
                name: "BookType",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("0aea58d7-f70b-43bc-8036-3381c2b1a310"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("321adbcd-e479-4882-a40d-566a0612cba5"), "Thriller", "Thrilling stories" },
                    { new Guid("4bbee21a-e179-46af-ac19-ebfe3e74b144"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("58f2a6cd-3cea-4fcc-a673-26af0b5bb2d0"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("59550b56-09bc-449d-b961-a8cf9085b7d7"), "Non Fiction", "Non-fictional content" },
                    { new Guid("5c4454ff-8a68-4649-b5ef-487fa617c46a"), "Romance Novel", "Romantic tales" },
                    { new Guid("6398fb45-3b53-4f89-977f-84d3ffe5bea9"), "Mystery", "Mystery novels" },
                    { new Guid("a176062e-4a5a-4ad2-86fe-7cc73d4a8b85"), "Fiction", "Fictional stories" },
                    { new Guid("c0db1a2f-cb6f-4f7a-a867-2027735d4f57"), "Biography", "Life stories of individuals" },
                    { new Guid("d8e34aad-709e-478f-a8c7-3f12112ceede"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("f0dd7c9d-8296-4813-909e-779542b60122"), "Humor", "Funny and comedic stories" },
                    { new Guid("f9c2ad55-9fe3-4bbd-abdb-d4b1496cd2d9"), "True Crime", "Real-life crime stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("12fd0985-5ec3-4500-8bf5-3d1d36cc4553"), "Tamil" },
                    { new Guid("7c978624-ff51-47a0-af9f-bd2cdf0a139b"), "English" },
                    { new Guid("e57c4f4f-6ab4-49d9-8c55-7963e523d9fd"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("02dae1bd-eb42-4c7e-8677-19f0277ada54"), "Member" },
                    { new Guid("fe311c3e-66ce-4c13-b703-18bc7d58ff1e"), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("0aea58d7-f70b-43bc-8036-3381c2b1a310"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("321adbcd-e479-4882-a40d-566a0612cba5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4bbee21a-e179-46af-ac19-ebfe3e74b144"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("58f2a6cd-3cea-4fcc-a673-26af0b5bb2d0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("59550b56-09bc-449d-b961-a8cf9085b7d7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("5c4454ff-8a68-4649-b5ef-487fa617c46a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("6398fb45-3b53-4f89-977f-84d3ffe5bea9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a176062e-4a5a-4ad2-86fe-7cc73d4a8b85"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("c0db1a2f-cb6f-4f7a-a867-2027735d4f57"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d8e34aad-709e-478f-a8c7-3f12112ceede"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f0dd7c9d-8296-4813-909e-779542b60122"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f9c2ad55-9fe3-4bbd-abdb-d4b1496cd2d9"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("12fd0985-5ec3-4500-8bf5-3d1d36cc4553"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7c978624-ff51-47a0-af9f-bd2cdf0a139b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e57c4f4f-6ab4-49d9-8c55-7963e523d9fd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("02dae1bd-eb42-4c7e-8677-19f0277ada54"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("fe311c3e-66ce-4c13-b703-18bc7d58ff1e"));

            migrationBuilder.DropColumn(
                name: "BookType",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("1621b0e9-5a63-4ceb-b910-e9e27b6a23ef"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("1c6e4e56-e189-4639-92bf-54853a0d91aa"), "Biography", "Life stories of individuals" },
                    { new Guid("446c4173-7ada-4298-82f7-c1285f1659ff"), "Non Fiction", "Non-fictional content" },
                    { new Guid("4b63d960-fa87-4b30-9eb2-0adc31e41127"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("581969bd-ea56-4b96-9368-f8466a88935b"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("6532555c-d40e-4fd6-95cb-08c368281240"), "Humor", "Funny and comedic stories" },
                    { new Guid("7039050c-9ca4-4cab-90ba-4362c7a6cec9"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("81182548-48c7-445a-97ce-195d835e0eb2"), "Romance Novel", "Romantic tales" },
                    { new Guid("d13289f4-5dd7-4b74-b675-69278a89478a"), "Thriller", "Thrilling stories" },
                    { new Guid("de22de14-bfe4-4808-95c1-24ea032c5ebc"), "Fiction", "Fictional stories" },
                    { new Guid("ea5c065b-91a5-4b73-b388-8fa614da261b"), "True Crime", "Real-life crime stories" },
                    { new Guid("edc4577d-1907-4a46-890b-30fa32e2d0e1"), "Mystery", "Mystery novels" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("541fc50f-cc7e-4178-8ddc-e20c620cc6d2"), "Tamil" },
                    { new Guid("73226e67-486b-484b-9b93-df4405a8dd9f"), "English" },
                    { new Guid("c9c7c3f0-996d-49c5-9905-3d9174222a5a"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("239d5ce1-16ad-4b7a-ad68-83f1f35def28"), "Member" },
                    { new Guid("43b7d1be-799e-4f6c-ac50-eb7bcecb0eb0"), "Admin" }
                });
        }
    }
}
