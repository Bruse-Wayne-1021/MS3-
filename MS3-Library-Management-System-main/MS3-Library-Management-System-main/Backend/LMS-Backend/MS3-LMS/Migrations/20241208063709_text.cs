using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class text : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "TextContent",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BookPdf",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPdf", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("085e61e5-7f76-41d6-8d95-c150df2d2ef8"), "Fiction", "Fictional stories" },
                    { new Guid("21dfe9b9-7624-414d-ba1d-8eac83070442"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("4cccd2d9-3a2f-429b-bba6-396098a2a48c"), "Humor", "Funny and comedic stories" },
                    { new Guid("5de10694-ba31-4128-b0b6-54676463335c"), "Thriller", "Thrilling stories" },
                    { new Guid("87b2cccb-50af-4f29-ba37-5c719f45b3e3"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("abe09275-5b48-4514-8211-75c3569a31a6"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("ad830c61-1f77-4595-8c8f-659ed9fa3cd5"), "Non Fiction", "Non-fictional content" },
                    { new Guid("b1d971ee-89d2-4ea5-ba35-617316d8dd71"), "Romance Novel", "Romantic tales" },
                    { new Guid("bb100d86-fba3-44d1-b745-59388510ba5d"), "True Crime", "Real-life crime stories" },
                    { new Guid("c26892e2-a51e-499d-bda6-efcb48f90999"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("dfd7fc69-3ba2-4918-87d6-111438a1f88b"), "Biography", "Life stories of individuals" },
                    { new Guid("eafe79d9-b500-412b-b928-51ada99d7d9b"), "Mystery", "Mystery novels" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("702e52d0-fee0-4d06-87a6-865c87a8a640"), "Singalam" },
                    { new Guid("8d9ef4a8-27d0-4fe3-86bc-295648f88602"), "English" },
                    { new Guid("e92470b0-d3b4-483c-b275-6d258b1b8474"), "Tamil" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("068e9da3-9596-4898-826d-854051def6b7"), "Admin" },
                    { new Guid("250bef08-9cd8-47af-b291-7f25e26b8cd5"), "Member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookPdf");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("085e61e5-7f76-41d6-8d95-c150df2d2ef8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("21dfe9b9-7624-414d-ba1d-8eac83070442"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4cccd2d9-3a2f-429b-bba6-396098a2a48c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("5de10694-ba31-4128-b0b6-54676463335c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("87b2cccb-50af-4f29-ba37-5c719f45b3e3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("abe09275-5b48-4514-8211-75c3569a31a6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ad830c61-1f77-4595-8c8f-659ed9fa3cd5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("b1d971ee-89d2-4ea5-ba35-617316d8dd71"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("bb100d86-fba3-44d1-b745-59388510ba5d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("c26892e2-a51e-499d-bda6-efcb48f90999"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("dfd7fc69-3ba2-4918-87d6-111438a1f88b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("eafe79d9-b500-412b-b928-51ada99d7d9b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("702e52d0-fee0-4d06-87a6-865c87a8a640"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8d9ef4a8-27d0-4fe3-86bc-295648f88602"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e92470b0-d3b4-483c-b275-6d258b1b8474"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("068e9da3-9596-4898-826d-854051def6b7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("250bef08-9cd8-47af-b291-7f25e26b8cd5"));

            migrationBuilder.DropColumn(
                name: "TextContent",
                table: "Books");

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
    }
}
