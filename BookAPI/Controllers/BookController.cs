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

        private IRegistrationService _registrationservice;
        public BookController(IRegistrationService registrationservice)
        {
            _registrationservice = registrationservice;
        }




        [HttpGet]
        [Route("authors")]

        public async Task<List<Author>> GetAuthors()
        {
            return await _registrationservice.GetAuthors();
        }

        //version 2
        [HttpGet]
        [Route("authorsdto")]
        /*
                public async Task<List<AuthorDTO>> GetAuthorsDTO()
                {
                    return await _context.AuthorsDTO.ToListAsync();
                }*/




        [HttpGet]
        [Route("genres")]
        public async Task<List<BookGenre>> GetGenres()
        {
            return await _registrationservice.GetGenres();
        }


        [HttpGet]
        [Route("books")]

        public async Task<ActionResult<List<Book>>> GetBooks(bool includeAuthor = false)
        {

            try
            {
                return await _registrationservice.GetBooks(includeAuthor);
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
                await _registrationservice.AddBook(book);
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
                await _registrationservice.DeleteBook(book);
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


