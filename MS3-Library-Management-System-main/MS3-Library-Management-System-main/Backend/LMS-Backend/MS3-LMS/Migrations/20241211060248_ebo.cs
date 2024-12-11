using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class ebo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("20e02271-3ebf-4767-a4fd-cc672798842d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("2778d7fa-2e01-41b6-8f37-9779a0062214"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4470e11b-a020-4988-807a-a2ec90bdd92f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("46d83547-b775-47f4-9250-6a86cbc01e03"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("509871a3-7c2d-4153-81c9-b44e27e367b3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("52a8ea4b-e8cc-4d27-bf9f-180acb6e1016"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("55c7cdb3-4526-4684-96a3-d1ed826b5b30"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("6ad84ed6-2a50-4ecf-b2a0-62a759ab3a29"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("b299cccf-2100-4b14-be32-5e712dd9051c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("bbf2ebaf-e773-4f4b-8a4a-f01988149022"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("c8c16002-594c-4b7c-b3d2-142869ba9c0f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("f9f0e3ab-23fd-4609-9b66-932e5f8751bc"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("157713e7-ce4a-4ac2-9327-15a3d9167929"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("30040352-043a-499d-ad4d-5b36fd9f98c1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d17f7e14-5ad6-44f0-8008-c3cfff907d9e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("6286153f-b9cb-440b-8d60-793a5e7a84bc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("66fbba3e-656e-4664-9ae0-a3e6f1167671"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("20e02271-3ebf-4767-a4fd-cc672798842d"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("2778d7fa-2e01-41b6-8f37-9779a0062214"), "Magical Realism", "Stories blending magic and realism" },
                    { new Guid("4470e11b-a020-4988-807a-a2ec90bdd92f"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("46d83547-b775-47f4-9250-6a86cbc01e03"), "Non Fiction", "Non-fictional content" },
                    { new Guid("509871a3-7c2d-4153-81c9-b44e27e367b3"), "Humor", "Funny and comedic stories" },
                    { new Guid("52a8ea4b-e8cc-4d27-bf9f-180acb6e1016"), "Biography", "Life stories of individuals" },
                    { new Guid("55c7cdb3-4526-4684-96a3-d1ed826b5b30"), "True Crime", "Real-life crime stories" },
                    { new Guid("6ad84ed6-2a50-4ecf-b2a0-62a759ab3a29"), "Mystery", "Mystery novels" },
                    { new Guid("b299cccf-2100-4b14-be32-5e712dd9051c"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("bbf2ebaf-e773-4f4b-8a4a-f01988149022"), "Thriller", "Thrilling stories" },
                    { new Guid("c8c16002-594c-4b7c-b3d2-142869ba9c0f"), "Romance Novel", "Romantic tales" },
                    { new Guid("f9f0e3ab-23fd-4609-9b66-932e5f8751bc"), "Fiction", "Fictional stories" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("157713e7-ce4a-4ac2-9327-15a3d9167929"), "English" },
                    { new Guid("30040352-043a-499d-ad4d-5b36fd9f98c1"), "Tamil" },
                    { new Guid("d17f7e14-5ad6-44f0-8008-c3cfff907d9e"), "Singala" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("6286153f-b9cb-440b-8d60-793a5e7a84bc"), "Member" },
                    { new Guid("66fbba3e-656e-4664-9ae0-a3e6f1167671"), "Admin" }
                });
        }
    }
}
