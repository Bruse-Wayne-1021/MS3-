using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class Ebook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<byte[]>(
                name: "FileData",
                table: "Books",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileFormat",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("14068d64-59f6-4a5c-8a85-0e784801edfa"), "Mystery", "Mystery novels" },
                    { new Guid("4ea9bbb0-5b70-4b57-bb72-f75e88af1008"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("5054e36d-aa09-4786-bae8-88dd3cf44ed9"), "Fiction", "Fictional stories" },
                    { new Guid("57065fd0-6c83-4037-bc0e-8fafea7ebf2a"), "Romance Novel", "Romantic tales" },
                    { new Guid("682eb82d-070b-4036-aa08-da1a780c2ed7"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("6e262da2-d1f8-45f2-b6a5-b4f2220e3d2a"), "Non Fiction", "Non-fictional content" },
                    { new Guid("96de8a94-7786-4452-8483-95057a385de9"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("9e5c2dad-9f2d-4319-b30e-379638d30792"), "True Crime", "Real-life crime stories" },
                    { new Guid("aecc58ed-77ed-41b1-a5e3-48ccae35fef7"), "Thriller", "Thrilling stories" },
                    { new Guid("b49c9662-3bda-4bda-bb2a-231a6038b458"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("d9524c11-af7d-46f7-af95-9dc96ab77925"), "Biography", "Life stories of individuals" },
                    { new Guid("df8df3c9-0840-4981-8d9e-1246c08b3519"), "Humor", "Funny and comedic stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("6eae01d7-31de-4063-b1fb-227e6fa5a830"), "Singalam" },
                    { new Guid("c481c951-1d81-4fe4-a4f1-89a471098fb2"), "Tamil" },
                    { new Guid("de1f15ec-3e6b-4593-a1d2-1e24d522c8eb"), "English" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("36b32166-a51a-43c5-b407-688f7fb627c6"), "Member" },
                    { new Guid("d64d799b-7735-4d01-a961-9e199767e400"), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("14068d64-59f6-4a5c-8a85-0e784801edfa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4ea9bbb0-5b70-4b57-bb72-f75e88af1008"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("5054e36d-aa09-4786-bae8-88dd3cf44ed9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("57065fd0-6c83-4037-bc0e-8fafea7ebf2a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("682eb82d-070b-4036-aa08-da1a780c2ed7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("6e262da2-d1f8-45f2-b6a5-b4f2220e3d2a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("96de8a94-7786-4452-8483-95057a385de9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9e5c2dad-9f2d-4319-b30e-379638d30792"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("aecc58ed-77ed-41b1-a5e3-48ccae35fef7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("b49c9662-3bda-4bda-bb2a-231a6038b458"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d9524c11-af7d-46f7-af95-9dc96ab77925"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("df8df3c9-0840-4981-8d9e-1246c08b3519"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("6eae01d7-31de-4063-b1fb-227e6fa5a830"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c481c951-1d81-4fe4-a4f1-89a471098fb2"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("de1f15ec-3e6b-4593-a1d2-1e24d522c8eb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("36b32166-a51a-43c5-b407-688f7fb627c6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("d64d799b-7735-4d01-a961-9e199767e400"));

            migrationBuilder.DropColumn(
                name: "FileData",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FileFormat",
                table: "Books");

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
    }
}
