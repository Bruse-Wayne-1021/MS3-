using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS3_LMS.Migrations
{
    /// <inheritdoc />
    public partial class pp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("33559b9b-f2dd-4022-b94b-92a8d23e79a0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("4f37586b-4e33-4bf0-8350-d675b78afdd4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("88b94d77-4e89-4396-9931-542ca3219518"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9a9855ff-213f-4787-835a-d6ed6c56016c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a71216cb-75dc-439a-acc5-80d90aadda20"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ba367de3-b0e3-4ca5-9c47-0add9c4a4d00"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("be577821-ca2a-47bc-b8b6-520eee5654b9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("c941ed7e-9498-4bfb-9b0b-63a50c82e064"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d888d035-1b3b-4747-b195-3b6ceb0d4d3f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e8761bef-92f4-48e9-b01c-857d7f6f7024"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ecbaa870-5711-41da-9e5f-e0ac295be56b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ecec1173-44bf-4f57-a346-6189434d5f76"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7418c30b-d8b2-40cf-ad3c-f0e2ed7872aa"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7c195ef6-0fd5-4d41-9857-57e01137f150"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("a4a135ef-207d-4835-a632-ad173c703af7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("00646c7b-7315-4a8e-8e3e-01ef01ae3c44"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("43e033cd-9d2a-401b-998a-83de6c6989e0"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookGenre", "Description" },
                values: new object[,]
                {
                    { new Guid("33559b9b-f2dd-4022-b94b-92a8d23e79a0"), "Mystery", "Mystery novels" },
                    { new Guid("4f37586b-4e33-4bf0-8350-d675b78afdd4"), "Humor", "Funny and comedic stories" },
                    { new Guid("88b94d77-4e89-4396-9931-542ca3219518"), "Biography", "Life stories of individuals" },
                    { new Guid("9a9855ff-213f-4787-835a-d6ed6c56016c"), "Fiction", "Fictional stories" },
                    { new Guid("a71216cb-75dc-439a-acc5-80d90aadda20"), "Thriller", "Thrilling stories" },
                    { new Guid("ba367de3-b0e3-4ca5-9c47-0add9c4a4d00"), "Fairy Tale", "Fairy tales and folklore" },
                    { new Guid("be577821-ca2a-47bc-b8b6-520eee5654b9"), "Non Fiction", "Non-fictional content" },
                    { new Guid("c941ed7e-9498-4bfb-9b0b-63a50c82e064"), "Romance Novel", "Romantic tales" },
                    { new Guid("d888d035-1b3b-4747-b195-3b6ceb0d4d3f"), "Graphic Novel", "Stories told through illustrations" },
                    { new Guid("e8761bef-92f4-48e9-b01c-857d7f6f7024"), "Science Fiction", "Sci-fi stories" },
                    { new Guid("ecbaa870-5711-41da-9e5f-e0ac295be56b"), "True Crime", "Real-life crime stories" },
                    { new Guid("ecec1173-44bf-4f57-a346-6189434d5f76"), "Magical Realism", "Stories blending magic and realism" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "TypeOfLanguage" },
                values: new object[,]
                {
                    { new Guid("7418c30b-d8b2-40cf-ad3c-f0e2ed7872aa"), "Singalam" },
                    { new Guid("7c195ef6-0fd5-4d41-9857-57e01137f150"), "Tamil" },
                    { new Guid("a4a135ef-207d-4835-a632-ad173c703af7"), "English" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "UserAType" },
                values: new object[,]
                {
                    { new Guid("00646c7b-7315-4a8e-8e3e-01ef01ae3c44"), "Admin" },
                    { new Guid("43e033cd-9d2a-401b-998a-83de6c6989e0"), "Member" }
                });
        }
    }
}
