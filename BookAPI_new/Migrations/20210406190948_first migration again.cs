using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAPI.Migrations
{
    public partial class firstmigrationagain : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "BookGenres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Age", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("7c1a8aba-f471-4e8e-8eb6-2afdc1e5bf4a"), 65, "Unites States", "Bill Gates" },
                    { new Guid("f22c79bf-cd53-43d4-a6cf-53598edb8c74"), 48, "United Kingdom", "Matthew Walker" },
                    { new Guid("9ae2375a-748b-45a3-8bf0-b5d4a6ce9a69"), 51, "Unites States", "Hope Jahren" },
                    { new Guid("f652beb4-20d8-462c-b6d7-8b0d142712cf"), 45, "United Kingdom", "Matt Haig" },
                    { new Guid("313d7cce-3823-4cf9-b686-2a3dd50907e8"), 35, "United Kingdom", "Lucy Foley" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookGenreId", "Genre" },
                values: new object[,]
                {
                    { new Guid("17a62fcc-a445-4fc2-bc77-ecde4ee0ad20"), "Fiction" },
                    { new Guid("2ae53231-c835-428f-adab-3215ab883379"), "Mystery & Thriller" },
                    { new Guid("d8c8060c-a3d9-4d9c-9d28-9e67b6d839ea"), "Nonfiction" },
                    { new Guid("0a9dcfd0-9369-4b53-a67d-13f9899569df"), "Science & Technology" },
                    { new Guid("0161529c-8dc4-4ad5-9c44-aafeffd57c48"), "Historical Fiction" },
                    { new Guid("b5f7dcf2-221c-4b06-9580-1cc4c8406b3d"), "Science & Technology" },
                    { new Guid("0454b66c-886b-481e-8f7e-3208b5bd6d01"), "Fantasy" },
                    { new Guid("24b47bb7-78b5-4b9e-804c-f345657d80f7"), "Romance" },
                    { new Guid("21dc7c93-0c1c-4f49-a9ca-16e4ee2cb465"), "Horror" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("313d7cce-3823-4cf9-b686-2a3dd50907e8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("7c1a8aba-f471-4e8e-8eb6-2afdc1e5bf4a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("9ae2375a-748b-45a3-8bf0-b5d4a6ce9a69"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("f22c79bf-cd53-43d4-a6cf-53598edb8c74"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("f652beb4-20d8-462c-b6d7-8b0d142712cf"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("0161529c-8dc4-4ad5-9c44-aafeffd57c48"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("0454b66c-886b-481e-8f7e-3208b5bd6d01"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("0a9dcfd0-9369-4b53-a67d-13f9899569df"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("17a62fcc-a445-4fc2-bc77-ecde4ee0ad20"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("21dc7c93-0c1c-4f49-a9ca-16e4ee2cb465"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("24b47bb7-78b5-4b9e-804c-f345657d80f7"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("2ae53231-c835-428f-adab-3215ab883379"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("b5f7dcf2-221c-4b06-9580-1cc4c8406b3d"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "BookGenreId",
                keyValue: new Guid("d8c8060c-a3d9-4d9c-9d28-9e67b6d839ea"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "BookGenres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
