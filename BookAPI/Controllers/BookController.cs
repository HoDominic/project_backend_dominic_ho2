using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookAPI.Data;
using BookAPI.DTO;
using BookAPI.Models;
using BookAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Controllers
{

    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]

    [Route("api")]
    public class BookController : ControllerBase
    {

        private IRegistrationService _registrationService;

        private IMapper _mapper;
        public BookController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }



        ///<summary>
        ///  Get authors
        ///</summary>


        [HttpGet]
        [Route("authors")]
        [MapToApiVersion("2.0")]

        public async Task<List<Author>> GetAuthors()
        {
            return await _registrationService.GetAuthors();
        }


        [HttpGet]
        [Route("authors")]

        public async Task<ActionResult<List<AuthorDTO>>> GetAuthorsDTO()
        {
            try
            {
                return _mapper.Map<List<AuthorDTO>>(await _registrationService.GetAuthorsDTO());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }




        ///<summary>
        ///  Get genres
        ///</summary>
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


        ///<summary>
        ///  Get suppliers
        ///</summary>
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

        ///<summary>
        ///  Get books
        ///</summary>

        [HttpGet]
        [Route("books")]
        public async Task<ActionResult<List<Book>>> GetBooks(string title = "", bool includeAuthor = false)
        {

            return await _registrationService.GetBooks(includeAuthor);

        }



        ///<summary>
        ///  Posta book
        ///</summary>

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



        ///<summary>
        ///  Delete a book
        ///</summary>

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






    }

}
