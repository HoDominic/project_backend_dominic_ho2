using System;
using System.Threading;
using System.Threading.Tasks;
using BookAPI.Configuration;
using BookAPI.DTO;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BookAPI.Data
{
    public interface IRegistrationContext
    {
        DbSet<Author> Authors { get; set; }

        DbSet<Book> Books { get; set; }
        DbSet<BookGenre> BookGenres { get; set; }
        DbSet<Supplier> Suppliers { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }

    public class RegistrationContext : DbContext, IRegistrationContext
    {
        public DbSet<Author> Authors { get; set; }



        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<BookSupplier> BookSuppliers { get; set; }


        private ConnectionStrings _connectionStrings;


        public RegistrationContext(DbContextOptions<RegistrationContext> options, IOptions<ConnectionStrings> connectionstrings)
        {
            _connectionStrings = connectionstrings.Value;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author() { AuthorId = Guid.NewGuid(), Name = "Bill Gates", Age = 65, Country = "Unites States" });
            modelBuilder.Entity<Author>().HasData(new Author() { AuthorId = Guid.NewGuid(), Name = "Matthew Walker", Age = 48, Country = "United Kingdom" });
            modelBuilder.Entity<Author>().HasData(new Author() { AuthorId = Guid.NewGuid(), Name = "Hope Jahren", Age = 51, Country = "Unites States" });
            modelBuilder.Entity<Author>().HasData(new Author() { AuthorId = Guid.NewGuid(), Name = "Matt Haig", Age = 45, Country = "United Kingdom" });
            modelBuilder.Entity<Author>().HasData(new Author() { AuthorId = Guid.NewGuid(), Name = "Lucy Foley", Age = 35, Country = "United Kingdom" });


            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Fiction" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Mystery & Thriller" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Nonfiction" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Science & Technology" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Historical Fiction" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Science & Technology" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Fantasy" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Romance" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Horror" });




            modelBuilder.Entity<BookSupplier>()
                  .HasKey(cs => new { cs.BookId, cs.SupplierId });



            modelBuilder.Entity<Supplier>().HasData(new Supplier()
            {
                SupplierId = 1,
                Name = "Standaard Boekhandel"
            });


            modelBuilder.Entity<Supplier>().HasData(new Supplier()
            {
                SupplierId = 2,
                Name = "De Boekuil "
            });

            modelBuilder.Entity<Supplier>().HasData(new Supplier()
            {
                SupplierId = 3,
                Name = "Athena "
            });


        }
    }
}
