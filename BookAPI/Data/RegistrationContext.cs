using System;
using BookAPI.Configuration;
using BookAPI.DTO;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BookAPI.Data
{
    public class RegistrationContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        //version2 
        public DbSet<AuthorDTO> AuthorsDTO { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }


        private ConnectionStrings _connectionStrings;


        public RegistrationContext(DbContextOptions<RegistrationContext> options, IOptions<ConnectionStrings> connectionstrings)
        {
            _connectionStrings = connectionstrings.Value;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }
    }
}
