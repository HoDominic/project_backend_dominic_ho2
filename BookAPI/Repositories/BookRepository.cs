using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookAPI.Data;
using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Repositories
{
    public interface IBookRepository
    {
        Task<Book> AddBook(Book book);
        Task<Book> DeleteBook(Book book);
        Task<List<Book>> GetBooks(bool includeAuthor);
    }

    public class BookRepository : IBookRepository
    {
        private IRegistrationContext _context;
        public BookRepository(IRegistrationContext context)
        {
            _context = context;
        }


        public async Task<List<Book>> GetBooks(bool includeAuthor)
        {

            if (includeAuthor) 
            {
                return await _context.Books.Include(r => r.Author).ToListAsync();
            }
            else
            {
                return await _context.Books.ToListAsync();
            }
        }


        public async Task<Book> AddBook(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return book;

        }


        public async Task<Book> DeleteBook(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return book;

        }


    }
}
