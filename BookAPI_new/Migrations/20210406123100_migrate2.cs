using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAPI.Migrations
{
    public partial class migrate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Age", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("025ef726-d795-46e8-9924-ada298d2bbcf"), 65, "Unites States", "Bill Gates" },
                    { new Guid("1061169b-428b-4530-82d7-3515f20c9faa"), 48, "United Kingdom", "Matthew Walker" },
                    { new Guid("bd930bdd-b64e-4003-ae73-92b3d6f327a2"), 51, "Unites States", "Hope Jahren" },
                    { new Guid("48c49527-dfe6-443b-ba39-a253dfd65a57"), 45, "United Kingdom", "Matt Haig" },
                    { new Guid("1223eb86-5325-42b1-b49c-79c27a077c4b"), 35, "United Kingdom", "Lucy Foley" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookGenreId", "Genre" },
                values: new object[,]
                {
                    { new Guid("e51f509c-c951-4541-94c7-75e7917550d6"), "Fiction" },
                    { new Guid("d9fd68b1-140d-4e51-ab07-b70dc2fdfd19"), "Mystery & Thriller" },
                    { new Guid("9cdaac42-a770-4026-af31-d654e47b65bc"), "Nonfiction" },
                    { new Guid("313ab2ad-854a-493e-91c7-6fa0e68637de"), "Science & Technology" },
                    { new Guid("43beb2b9-7793-4ca6-a62e-7c7d57e52926"), "Historical Fiction" },
                    { new Guid("0182d2a9-6025-4443-805b-357a47788151"), "Science & Technology" },
                    { new Guid("6db6e21b-46cd-4a65-baa9-66e9cbb9d9f7"), "Fantasy" },
                    { new Guid("d15063fc-ced0-4380-a513-4546ef94ff63"), "Romance" },
                    { new Guid("d72395ba-8b4e-4084-8fa5-5ad31dce1223"), "Horror" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("025ef726-d795-46e8-9924-ada298d2bbcf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("1061169b-428b-4530-82d7-3515f20c9faa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("1223eb86-5325-42b1-b49c-79c27a077c4b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("48c49527-dfe6-443b-ba39-a253dfd65a57"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("bd930bdd-b64e-4003-ae73-92b3d6f327a2"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("0182d2a9-6025-4443-805b-357a47788151"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("313ab2ad-854a-493e-91c7-6fa0e68637de"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("43beb2b9-7793-4ca6-a62e-7c7d57e52926"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("6db6e21b-46cd-4a65-baa9-66e9cbb9d9f7"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("9cdaac42-a770-4026-af31-d654e47b65bc"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("d15063fc-ced0-4380-a513-4546ef94ff63"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("d72395ba-8b4e-4084-8fa5-5ad31dce1223"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("d9fd68b1-140d-4e51-ab07-b70dc2fdfd19"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("e51f509c-c951-4541-94c7-75e7917550d6"));

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
                    { new Guid("c44022d1-629a-4a64-b05a-9ca7cdadabf4"), "Fiction" },
                    { new Guid("c0e2fd71-64f8-4480-a6e8-8349d50a99be"), "Mystery & Thriller" },
                    { new Guid("a21da655-a425-4837-a82f-392498240d8b"), "Nonfiction" },
                    { new Guid("a94d7b38-f321-4d06-a174-c7b8cc0c3c71"), "Science & Technology" },
                    { new Guid("d3cc3e0b-6105-4c7c-aadd-ed68428aec12"), "Historical Fiction" },
                    { new Guid("d4810793-ca51-4f90-b4df-39e0d5411fdc"), "Science & Technology" },
                    { new Guid("b50b2d94-5fa3-42e4-8689-287faae9b0c4"), "Fantasy" },
                    { new Guid("db55ddaa-c127-40b2-a6fc-9e4ef3825376"), "Romance" },
                    { new Guid("80c5eefe-47cc-4704-9e94-24c6cc1905cc"), "Horror" }
                });
        }
    }
}
