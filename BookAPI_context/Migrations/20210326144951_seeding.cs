using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAPI.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Age", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("a5d4bb59-faa9-477d-99f1-2273118d3313"), 35, "United Kingdom", "Lucy Foley" },
                    { new Guid("f4fffbbd-5480-4ada-9c16-e231c4542bb0"), 45, "United Kingdom", "Matt Haig" },
                    { new Guid("e274833e-192e-4a10-b1d4-ad2e0b9a8cd7"), 51, "Unites States", "Hope Jahren" },
                    { new Guid("70fd1fce-e1b8-4893-87ea-0c21a1892cd8"), 48, "United Kingdom", "Matthew Walker" },
                    { new Guid("dd29c07c-3fe6-4c39-8a45-e6a8f339f49b"), 65, "Unites States", "Bill Gates" }
                });

            migrationBuilder.InsertData(
                table: "AuthorsDTO",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { new Guid("4f281332-a9c8-4ff7-9c30-656d9fe1bd94"), "Bill Gates" },
                    { new Guid("e63b3611-c380-445c-bb16-db18c1b2c437"), "Matt Haig" },
                    { new Guid("1c667928-d1c6-4bff-bd1d-24b2cb787f0f"), "Hope Jahren" },
                    { new Guid("2df269e3-9af9-45d3-a1ef-577dd68e0862"), "Matthew Walker" },
                    { new Guid("c8140706-efb9-4727-bb3e-b9b4e4448345"), "Lucy Foley" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookGenreId", "Genre" },
                values: new object[,]
                {
                    { new Guid("90e2995b-2e46-4bb3-b9eb-d15996acc913"), "Romance" },
                    { new Guid("5145e3c2-8ec6-4677-827b-e8b1e16a1e98"), "Fiction" },
                    { new Guid("61d89ad1-ced9-4c73-9342-0ed2b143448d"), "Mystery & Thriller" },
                    { new Guid("2480bc1e-43ae-4667-97da-ec69791425ac"), "Nonfiction" },
                    { new Guid("c8696366-2e19-4efc-bbc3-180be7551713"), "Science & Technology" },
                    { new Guid("9a415047-48f7-453f-b957-fac93db79332"), "Historical Fiction" },
                    { new Guid("7c60b696-8f4c-426d-9cb1-701744d91806"), "Science & Technology" },
                    { new Guid("dcc4fe79-1341-4243-b2ee-210d0df5d17e"), "Fantasy" },
                    { new Guid("fa25d4a9-cb63-456c-9d0f-03d0f488dfd6"), "Horror" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("70fd1fce-e1b8-4893-87ea-0c21a1892cd8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("a5d4bb59-faa9-477d-99f1-2273118d3313"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("dd29c07c-3fe6-4c39-8a45-e6a8f339f49b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("e274833e-192e-4a10-b1d4-ad2e0b9a8cd7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("f4fffbbd-5480-4ada-9c16-e231c4542bb0"));

            migrationBuilder.DeleteData(
                table: "AuthorsDTO",
                keyColumn: "AuthorId",
                keyValue: new Guid("1c667928-d1c6-4bff-bd1d-24b2cb787f0f"));

            migrationBuilder.DeleteData(
                table: "AuthorsDTO",
                keyColumn: "AuthorId",
                keyValue: new Guid("2df269e3-9af9-45d3-a1ef-577dd68e0862"));

            migrationBuilder.DeleteData(
                table: "AuthorsDTO",
                keyColumn: "AuthorId",
                keyValue: new Guid("4f281332-a9c8-4ff7-9c30-656d9fe1bd94"));

            migrationBuilder.DeleteData(
                table: "AuthorsDTO",
                keyColumn: "AuthorId",
                keyValue: new Guid("c8140706-efb9-4727-bb3e-b9b4e4448345"));

            migrationBuilder.DeleteData(
                table: "AuthorsDTO",
                keyColumn: "AuthorId",
                keyValue: new Guid("e63b3611-c380-445c-bb16-db18c1b2c437"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("2480bc1e-43ae-4667-97da-ec69791425ac"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("5145e3c2-8ec6-4677-827b-e8b1e16a1e98"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("61d89ad1-ced9-4c73-9342-0ed2b143448d"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("7c60b696-8f4c-426d-9cb1-701744d91806"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("90e2995b-2e46-4bb3-b9eb-d15996acc913"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("9a415047-48f7-453f-b957-fac93db79332"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("c8696366-2e19-4efc-bbc3-180be7551713"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("dcc4fe79-1341-4243-b2ee-210d0df5d17e"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("fa25d4a9-cb63-456c-9d0f-03d0f488dfd6"));
        }
    }
}
