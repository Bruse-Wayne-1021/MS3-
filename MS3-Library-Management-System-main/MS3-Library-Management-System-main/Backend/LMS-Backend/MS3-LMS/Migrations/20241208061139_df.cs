using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class df : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("3d22f4bd-3d93-4ebc-a1e9-8342da5ecb03"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("589ccfd9-7e1f-479c-9fc5-b84c5edf9f56"), "Non Fiction", "Non-fictional content" },
                    { new Guid("636d888a-d2e6-4801-bd88-4f88754dd65c"), "Thriller", "Thrilling stories" },
                    { new Guid("64a420ad-d3bf-444f-9fe0-283ef5b68505"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("72f4dfb1-475e-421e-b21b-9e9cd03cc3e3"), "Mystery", "Mystery novels" },
                    { new Guid("73c33982-8d42-4baa-bfed-8093f5870435"), "Fiction", "Fictional stories" },
                    { new Guid("923cc9eb-2c12-443e-a6db-4fe113f490ed"), "True Crime", "Real-life crime stories" },
                    { new Guid("971ee420-8808-4e02-ab50-b1c14e837d3a"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("ce5b59a8-72b8-4a33-b64a-2cce6d006ea0"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("dbc5b430-64b5-49c0-806e-dc07dfe2cb25"), "Humor", "Funny and comedic stories" },
                    { new Guid("e19f8280-a2ef-45ac-99bb-81943f936efe"), "Romance Novel", "Romantic tales" },
                    { new Guid("f04d0acb-af5b-4e47-bea8-68da334417f0"), "Biography", "Life stories of individuals" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("10d2999f-a455-425f-b987-067f12849f84"), "English" },
                    { new Guid("eeaea7a9-1e43-4f28-bb7e-baf1742bd462"), "Tamil" },
                    { new Guid("f6f04e37-f057-4aaa-8bdf-63f635912c67"), "Singalam" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("f3ed2191-e840-46a3-9489-3a131094c743"), "Admin" },
                    { new Guid("fc1b3553-871d-49b8-b27b-88b16bc35dc7"), "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("3d22f4bd-3d93-4ebc-a1e9-8342da5ecb03"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("589ccfd9-7e1f-479c-9fc5-b84c5edf9f56"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("636d888a-d2e6-4801-bd88-4f88754dd65c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("64a420ad-d3bf-444f-9fe0-283ef5b68505"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("72f4dfb1-475e-421e-b21b-9e9cd03cc3e3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("73c33982-8d42-4baa-bfed-8093f5870435"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("923cc9eb-2c12-443e-a6db-4fe113f490ed"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("971ee420-8808-4e02-ab50-b1c14e837d3a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ce5b59a8-72b8-4a33-b64a-2cce6d006ea0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("dbc5b430-64b5-49c0-806e-dc07dfe2cb25"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e19f8280-a2ef-45ac-99bb-81943f936efe"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f04d0acb-af5b-4e47-bea8-68da334417f0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("10d2999f-a455-425f-b987-067f12849f84"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("eeaea7a9-1e43-4f28-bb7e-baf1742bd462"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f6f04e37-f057-4aaa-8bdf-63f635912c67"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("f3ed2191-e840-46a3-9489-3a131094c743"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("fc1b3553-871d-49b8-b27b-88b16bc35dc7"));

            migrationBuilder.DropColumn(
                name: "FilePath",
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
    }
}
