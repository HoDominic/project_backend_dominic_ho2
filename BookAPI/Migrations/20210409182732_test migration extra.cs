using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAPI.Migrations
{
    public partial class testmigrationextra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("e99b0983-dd40-402b-839f-9a326e3c1b21"), 65, "Unites States", "Bill Gates" },
                    { new Guid("49ede919-829e-4727-8fa0-19515b2c579b"), 48, "United Kingdom", "Matthew Walker" },
                    { new Guid("8c3bdd93-2fa3-4504-a6aa-6cf1d68a9c33"), 51, "Unites States", "Hope Jahren" },
                    { new Guid("7b47c724-dcba-4fe4-91a7-a7ac93437403"), 45, "United Kingdom", "Matt Haig" },
                    { new Guid("f15e7a1f-adf9-4fa3-bf60-74f464f3d5c1"), 35, "United Kingdom", "Lucy Foley" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookGenreId", "Genre" },
                values: new object[,]
                {
                    { new Guid("b62b8b58-7f80-4c59-a43b-2b7d092eee22"), "Fiction" },
                    { new Guid("4ccf13a4-f6ec-4f95-98f8-d52af5b2ba9e"), "Mystery & Thriller" },
                    { new Guid("ae873c67-0c8f-4bc2-b9fe-d4eb9bc5cb50"), "Nonfiction" },
                    { new Guid("926b4dee-788a-4676-826b-c334a1803074"), "Science & Technology" },
                    { new Guid("a2f4be33-b1bb-4555-b27f-9f180e6e5fe4"), "Historical Fiction" },
                    { new Guid("dc31a872-3e29-4f25-8f7b-a876a92d20e8"), "Science & Technology" },
                    { new Guid("dd0c05d9-99ca-4e68-a5cb-a2eceb283095"), "Fantasy" },
                    { new Guid("6dfe9b50-5c96-4acd-91d7-171c8d657a79"), "Romance" },
                    { new Guid("a841826b-7375-41f0-9515-2f4ac8b7a7ab"), "Horror" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("49ede919-829e-4727-8fa0-19515b2c579b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("7b47c724-dcba-4fe4-91a7-a7ac93437403"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("8c3bdd93-2fa3-4504-a6aa-6cf1d68a9c33"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("e99b0983-dd40-402b-839f-9a326e3c1b21"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("f15e7a1f-adf9-4fa3-bf60-74f464f3d5c1"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("4ccf13a4-f6ec-4f95-98f8-d52af5b2ba9e"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("6dfe9b50-5c96-4acd-91d7-171c8d657a79"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("926b4dee-788a-4676-826b-c334a1803074"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("a2f4be33-b1bb-4555-b27f-9f180e6e5fe4"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("a841826b-7375-41f0-9515-2f4ac8b7a7ab"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("ae873c67-0c8f-4bc2-b9fe-d4eb9bc5cb50"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("b62b8b58-7f80-4c59-a43b-2b7d092eee22"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("dc31a872-3e29-4f25-8f7b-a876a92d20e8"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("dd0c05d9-99ca-4e68-a5cb-a2eceb283095"));

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
    }
}
