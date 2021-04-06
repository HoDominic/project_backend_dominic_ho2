using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAPI.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorsDTO");

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

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "BookSuppliers",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookSuppliers", x => new { x.BookId, x.SupplierId });
                    table.ForeignKey(
                        name: "FK_BookSuppliers_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookSuppliers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Age", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("d9d2abc9-c06c-4d51-a247-bce5a4128d7f"), 65, "Unites States", "Bill Gates" },
                    { new Guid("75805ed7-d5a1-40b8-b876-36c9e2b7ac5f"), 48, "United Kingdom", "Matthew Walker" },
                    { new Guid("2edb85ed-bc62-4d43-b17f-13bb77878ba0"), 51, "Unites States", "Hope Jahren" },
                    { new Guid("53b4bf5a-6c91-447c-82b2-c06efb5f1529"), 45, "United Kingdom", "Matt Haig" },
                    { new Guid("1d53f5a5-3092-4eda-86d6-91d501b8b3fe"), 35, "United Kingdom", "Lucy Foley" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookGenreId", "Genre" },
                values: new object[,]
                {
                    { new Guid("80c5eefe-47cc-4704-9e94-24c6cc1905cc"), "Horror" },
                    { new Guid("db55ddaa-c127-40b2-a6fc-9e4ef3825376"), "Romance" },
                    { new Guid("b50b2d94-5fa3-42e4-8689-287faae9b0c4"), "Fantasy" },
                    { new Guid("d4810793-ca51-4f90-b4df-39e0d5411fdc"), "Science & Technology" },
                    { new Guid("a94d7b38-f321-4d06-a174-c7b8cc0c3c71"), "Science & Technology" },
                    { new Guid("a21da655-a425-4837-a82f-392498240d8b"), "Nonfiction" },
                    { new Guid("c0e2fd71-64f8-4480-a6e8-8349d50a99be"), "Mystery & Thriller" },
                    { new Guid("c44022d1-629a-4a64-b05a-9ca7cdadabf4"), "Fiction" },
                    { new Guid("d3cc3e0b-6105-4c7c-aadd-ed68428aec12"), "Historical Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Name" },
                values: new object[,]
                {
                    { 2, "De Boekuil " },
                    { 1, "Standaard Boekhandel" },
                    { 3, "Athena " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookSuppliers_SupplierId",
                table: "BookSuppliers",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookSuppliers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("1d53f5a5-3092-4eda-86d6-91d501b8b3fe"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("2edb85ed-bc62-4d43-b17f-13bb77878ba0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("53b4bf5a-6c91-447c-82b2-c06efb5f1529"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("75805ed7-d5a1-40b8-b876-36c9e2b7ac5f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("d9d2abc9-c06c-4d51-a247-bce5a4128d7f"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("80c5eefe-47cc-4704-9e94-24c6cc1905cc"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("a21da655-a425-4837-a82f-392498240d8b"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("a94d7b38-f321-4d06-a174-c7b8cc0c3c71"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("b50b2d94-5fa3-42e4-8689-287faae9b0c4"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("c0e2fd71-64f8-4480-a6e8-8349d50a99be"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("c44022d1-629a-4a64-b05a-9ca7cdadabf4"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("d3cc3e0b-6105-4c7c-aadd-ed68428aec12"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("d4810793-ca51-4f90-b4df-39e0d5411fdc"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("db55ddaa-c127-40b2-a6fc-9e4ef3825376"));

            migrationBuilder.CreateTable(
                name: "AuthorsDTO",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorsDTO", x => x.AuthorId);
                });

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
    }
}
