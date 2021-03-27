﻿// <auto-generated />
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
    [Migration("20210326144951_seeding")]
    partial class seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("BookAPI.DTO.AuthorDTO", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("AuthorsDTO");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("4f281332-a9c8-4ff7-9c30-656d9fe1bd94"),
                            Name = "Bill Gates"
                        },
                        new
                        {
                            AuthorId = new Guid("2df269e3-9af9-45d3-a1ef-577dd68e0862"),
                            Name = "Matthew Walker"
                        },
                        new
                        {
                            AuthorId = new Guid("1c667928-d1c6-4bff-bd1d-24b2cb787f0f"),
                            Name = "Hope Jahren"
                        },
                        new
                        {
                            AuthorId = new Guid("e63b3611-c380-445c-bb16-db18c1b2c437"),
                            Name = "Matt Haig"
                        },
                        new
                        {
                            AuthorId = new Guid("c8140706-efb9-4727-bb3e-b9b4e4448345"),
                            Name = "Lucy Foley"
                        });
                });

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
                            AuthorId = new Guid("dd29c07c-3fe6-4c39-8a45-e6a8f339f49b"),
                            Age = 65,
                            Country = "Unites States",
                            Name = "Bill Gates"
                        },
                        new
                        {
                            AuthorId = new Guid("70fd1fce-e1b8-4893-87ea-0c21a1892cd8"),
                            Age = 48,
                            Country = "United Kingdom",
                            Name = "Matthew Walker"
                        },
                        new
                        {
                            AuthorId = new Guid("e274833e-192e-4a10-b1d4-ad2e0b9a8cd7"),
                            Age = 51,
                            Country = "Unites States",
                            Name = "Hope Jahren"
                        },
                        new
                        {
                            AuthorId = new Guid("f4fffbbd-5480-4ada-9c16-e231c4542bb0"),
                            Age = 45,
                            Country = "United Kingdom",
                            Name = "Matt Haig"
                        },
                        new
                        {
                            AuthorId = new Guid("a5d4bb59-faa9-477d-99f1-2273118d3313"),
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
                            BookGenreId = new Guid("5145e3c2-8ec6-4677-827b-e8b1e16a1e98"),
                            Genre = "Fiction"
                        },
                        new
                        {
                            BookGenreId = new Guid("61d89ad1-ced9-4c73-9342-0ed2b143448d"),
                            Genre = "Mystery & Thriller"
                        },
                        new
                        {
                            BookGenreId = new Guid("2480bc1e-43ae-4667-97da-ec69791425ac"),
                            Genre = "Nonfiction"
                        },
                        new
                        {
                            BookGenreId = new Guid("c8696366-2e19-4efc-bbc3-180be7551713"),
                            Genre = "Science & Technology"
                        },
                        new
                        {
                            BookGenreId = new Guid("9a415047-48f7-453f-b957-fac93db79332"),
                            Genre = "Historical Fiction"
                        },
                        new
                        {
                            BookGenreId = new Guid("7c60b696-8f4c-426d-9cb1-701744d91806"),
                            Genre = "Science & Technology"
                        },
                        new
                        {
                            BookGenreId = new Guid("dcc4fe79-1341-4243-b2ee-210d0df5d17e"),
                            Genre = "Fantasy"
                        },
                        new
                        {
                            BookGenreId = new Guid("90e2995b-2e46-4bb3-b9eb-d15996acc913"),
                            Genre = "Romance"
                        },
                        new
                        {
                            BookGenreId = new Guid("fa25d4a9-cb63-456c-9d0f-03d0f488dfd6"),
                            Genre = "Horror"
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
#pragma warning restore 612, 618
        }
    }
}
