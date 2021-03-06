// <auto-generated />
using System;
using BookAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookAPI.Migrations
{
    [DbContext(typeof(RegistrationContext))]
    [Migration("20210406123100_migrate2")]
    partial class migrate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("BookAPI.Models.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("025ef726-d795-46e8-9924-ada298d2bbcf"),
                            Age = 65,
                            Country = "Unites States",
                            Name = "Bill Gates"
                        },
                        new
                        {
                            AuthorId = new Guid("1061169b-428b-4530-82d7-3515f20c9faa"),
                            Age = 48,
                            Country = "United Kingdom",
                            Name = "Matthew Walker"
                        },
                        new
                        {
                            AuthorId = new Guid("bd930bdd-b64e-4003-ae73-92b3d6f327a2"),
                            Age = 51,
                            Country = "Unites States",
                            Name = "Hope Jahren"
                        },
                        new
                        {
                            AuthorId = new Guid("48c49527-dfe6-443b-ba39-a253dfd65a57"),
                            Age = 45,
                            Country = "United Kingdom",
                            Name = "Matt Haig"
                        },
                        new
                        {
                            AuthorId = new Guid("1223eb86-5325-42b1-b49c-79c27a077c4b"),
                            Age = 35,
                            Country = "United Kingdom",
                            Name = "Lucy Foley"
                        });
                });

            modelBuilder.Entity("BookAPI.Models.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookGenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookAPI.Models.BookGenre", b =>
                {
                    b.Property<Guid>("BookGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookGenreId");

                    b.ToTable("BookGenres");

                    b.HasData(
                        new
                        {
                            BookGenreId = new Guid("e51f509c-c951-4541-94c7-75e7917550d6"),
                            Genre = "Fiction"
                        },
                        new
                        {
                            BookGenreId = new Guid("d9fd68b1-140d-4e51-ab07-b70dc2fdfd19"),
                            Genre = "Mystery & Thriller"
                        },
                        new
                        {
                            BookGenreId = new Guid("9cdaac42-a770-4026-af31-d654e47b65bc"),
                            Genre = "Nonfiction"
                        },
                        new
                        {
                            BookGenreId = new Guid("313ab2ad-854a-493e-91c7-6fa0e68637de"),
                            Genre = "Science & Technology"
                        },
                        new
                        {
                            BookGenreId = new Guid("43beb2b9-7793-4ca6-a62e-7c7d57e52926"),
                            Genre = "Historical Fiction"
                        },
                        new
                        {
                            BookGenreId = new Guid("0182d2a9-6025-4443-805b-357a47788151"),
                            Genre = "Science & Technology"
                        },
                        new
                        {
                            BookGenreId = new Guid("6db6e21b-46cd-4a65-baa9-66e9cbb9d9f7"),
                            Genre = "Fantasy"
                        },
                        new
                        {
                            BookGenreId = new Guid("d15063fc-ced0-4380-a513-4546ef94ff63"),
                            Genre = "Romance"
                        },
                        new
                        {
                            BookGenreId = new Guid("d72395ba-8b4e-4084-8fa5-5ad31dce1223"),
                            Genre = "Horror"
                        });
                });

            modelBuilder.Entity("BookAPI.Models.BookSupplier", b =>
                {
                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "SupplierId");

                    b.HasIndex("SupplierId");

                    b.ToTable("BookSuppliers");
                });

            modelBuilder.Entity("BookAPI.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            Name = "Standaard Boekhandel"
                        },
                        new
                        {
                            SupplierId = 2,
                            Name = "De Boekuil "
                        },
                        new
                        {
                            SupplierId = 3,
                            Name = "Athena "
                        });
                });

            modelBuilder.Entity("BookAPI.Models.Book", b =>
                {
                    b.HasOne("BookAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BookAPI.Models.BookSupplier", b =>
                {
                    b.HasOne("BookAPI.Models.Book", "Book")
                        .WithMany("BookSuppliers")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookAPI.Models.Supplier", "Supplier")
                        .WithMany("BookSuppliers")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("BookAPI.Models.Book", b =>
                {
                    b.Navigation("BookSuppliers");
                });

            modelBuilder.Entity("BookAPI.Models.Supplier", b =>
                {
                    b.Navigation("BookSuppliers");
                });
#pragma warning restore 612, 618
        }
    }
}
