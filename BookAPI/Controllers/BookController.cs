using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Data;
using BookAPI.DTO;
using BookAPI.Models;
using BookAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Controllers
{

    [ApiController]
    [Route("api")]
    public class BookController : ControllerBase
    {

        private IRegistrationService _registrationService;
        public BookController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }


        /// <summary>
        /// Get Authors
        /// </summary>

        [HttpGet]
        [Route("authors")]

        public async Task<List<Author>> GetAuthors()
        {
            return await _registrationService.GetAuthors();
        }

        //version 2
        // [HttpGet]
        // [Route("authorsdto")]
        /*
                public async Task<List<AuthorDTO>> GetAuthorsDTO()
                {
                    return await _context.AuthorsDTO.ToListAsync();
                }

        */


        /// <summary>
        /// Get Genres
        /// </summary>

        [HttpGet]
        [Route("genres")]
        public async Task<ActionResult<List<BookGenre>>> GetGenres()
        {
            try
            {
                return new OkObjectResult(await _registrationService.GetGenres());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
        // {
        //     return await _registrationService.GetGenres();
        // }

        /// <summary>
        /// Get Suppliers
        /// </summary>

        [HttpGet]
        [Route("suppliers")]
        public async Task<ActionResult<List<Supplier>>> GetSuppliers()
        {
            try
            {
                return new OkObjectResult(await _registrationService.GetSuppliers());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }



        /// <summary>
        /// Get Books
        /// </summary>

        [HttpGet]
        [Route("books")]
        public async Task<ActionResult<List<Book>>> GetBooks(string title = "", bool includeAuthor = false)
        {

            return await _registrationService.GetBooks(includeAuthor);

        }



        /// <summary>
        /// Insert a Book
        /// </summary>

        [HttpPost]
        [Route("book")]

        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            try
            {
                return await _registrationService.AddBook(book);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }


        /// <summary>
        /// Delete a Book
        /// </summary>

        [HttpDelete]
        [Route("book")]

        public async Task<ActionResult<Book>> DeleteBook(Book book)
        {
            try
            {

                return await _registrationService.DeleteBook(book);

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
