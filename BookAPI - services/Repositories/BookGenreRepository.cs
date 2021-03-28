using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookAPI.Data;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Repositories
{
    public interface IBookGenreRepository
    {
        Task<List<BookGenre>> GetGenres();
    }

    public class BookGenreRepository : IBookGenreRepository
    {
        private IRegistrationContext _context;
        public BookGenreRepository(IRegistrationContext context)
        {
            _context = context;
        }


        public async Task<List<BookGenre>> GetGenres()
        {
            return await _context.BookGenres.ToListAsync();
        }


    }
}
