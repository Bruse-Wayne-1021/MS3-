using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class efpodkfopkdof : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("08ce40fb-d4a2-4d9a-80a4-b7320d7c4502"), "Mystery", "Mystery novels" },
                    { new Guid("20994a1c-7d17-4a89-bcd6-d33443dfbe27"), "Thriller", "Thrilling stories" },
                    { new Guid("26dc431c-06d0-4da8-b335-b76cf44e4289"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("5b5e281b-197f-49bd-ac2a-d22d66a43e6b"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("63575c1b-200a-4581-88e6-1fee5b242a64"), "Biography", "Life stories of individuals" },
                    { new Guid("639ee526-e711-47bd-89a6-debf4a82cd28"), "Non Fiction", "Non-fictional content" },
                    { new Guid("7e8b676d-85f6-4cd3-83ae-e682b71b45b6"), "Fiction", "Fictional stories" },
                    { new Guid("8d5ebcb9-7ae7-4522-9625-4e7235619f4e"), "Humor", "Funny and comedic stories" },
                    { new Guid("b1acb4c4-7556-459d-b657-df1c31a160bb"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("e908a790-b1d4-4ffd-b775-9c9f4ed31585"), "Romance Novel", "Romantic tales" },
                    { new Guid("eca29df8-53bb-41e0-aba8-4dd59f2b59a9"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("f3b301ca-5f4f-463b-a61e-107da414eb76"), "True Crime", "Real-life crime stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("2e6db4a6-46a9-4290-a546-0f3f94ef37e3"), "Tamil" },
                    { new Guid("c4bb7ec7-4121-4477-8180-8a3136d1bb55"), "English" },
                    { new Guid("e448bc36-13ee-45e9-a49d-abbd39693370"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("08d76e7d-dc47-43c9-a144-49eee0aa0fd0"), "Admin" },
                    { new Guid("dff9e544-7fd6-4d5c-818f-5f26155ece11"), "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("08ce40fb-d4a2-4d9a-80a4-b7320d7c4502"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("20994a1c-7d17-4a89-bcd6-d33443dfbe27"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("26dc431c-06d0-4da8-b335-b76cf44e4289"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("5b5e281b-197f-49bd-ac2a-d22d66a43e6b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("63575c1b-200a-4581-88e6-1fee5b242a64"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("639ee526-e711-47bd-89a6-debf4a82cd28"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("7e8b676d-85f6-4cd3-83ae-e682b71b45b6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("8d5ebcb9-7ae7-4522-9625-4e7235619f4e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("b1acb4c4-7556-459d-b657-df1c31a160bb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e908a790-b1d4-4ffd-b775-9c9f4ed31585"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("eca29df8-53bb-41e0-aba8-4dd59f2b59a9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f3b301ca-5f4f-463b-a61e-107da414eb76"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2e6db4a6-46a9-4290-a546-0f3f94ef37e3"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c4bb7ec7-4121-4477-8180-8a3136d1bb55"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e448bc36-13ee-45e9-a49d-abbd39693370"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("08d76e7d-dc47-43c9-a144-49eee0aa0fd0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("dff9e544-7fd6-4d5c-818f-5f26155ece11"));

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
    }
}
