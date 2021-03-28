using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Data;
using BookAPI.DTO;
using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Controllers
{

    [ApiController]
    [Route("api")]
    public class BookController : ControllerBase
    {

        private RegistrationContext _context;
        public BookController(RegistrationContext context)
        {
            _context = context;
        }




        [HttpGet]
        [Route("authors")]

        public async Task<List<Author>> GetAuthors()
        {
            return await _context.Authors.ToListAsync();
        }

        //version 2
        [HttpGet]
        [Route("authorsdto")]

        public async Task<List<AuthorDTO>> GetAuthorsDTO()
        {
            return await _context.AuthorsDTO.ToListAsync();
        }




        [HttpGet]
        [Route("genres")]
        public async Task<List<BookGenre>> GetGenres()
        {
            return await _context.BookGenres.ToListAsync();
        }


        [HttpGet]
        [Route("books")]
        public async Task<ActionResult<List<Book>>> GetBooks(string title = "", bool includeAuthor = false)
        {

            try
            {
                if (!string.IsNullOrEmpty(title))
                {
                    if (includeAuthor)
                    {

                        return await _context.Books.Include(r => r.Author).Where(r => r.Title == title).ToListAsync();
                    }
                    else
                    {
                        return await _context.Books.Where(r => r.Title == title).ToListAsync();
                    }

                }
                else
                {
                    if (includeAuthor)
                    {
                        return await _context.Books.ToListAsync();
                    }
                    else
                    {
                        return await _context.Books.ToListAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }

        }





        [HttpPost]
        [Route("book")]

        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            try
            {
                await _context.Books.AddAsync(book);
                await _context.SaveChangesAsync();
                return book;
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete]
        [Route("book")]

        public async Task<ActionResult<Book>> DeleteBook(Book book)
        {
            try
            {

                _context.Books.Remove(book);
                await _context.SaveChangesAsync();

                return book;

            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }



        // [HttpPut]
        // [Route("book")]

        // public async Task<ActionResult<Book>> UpdateBook(Book book)
        // {

        //     try
        //     {
        //         Book newbook = book.Find(b => b.bookId == book.BookId);

        //         _context.Books.Remove(book);
        //         await _context.Books.AddAsync(newbook);
        //         await _context.SaveChangesAsync();
        //         return newbook;

        //     }
        //     catch (Exception ex)
        //     {
        //         return new OkObjectResult(book);
        //     }
        // }


    }

}
