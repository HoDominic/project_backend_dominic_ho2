using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookAPI.Data;
using BookAPI.DTO;
using BookAPI.Models;
using BookAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Controllers
{

    //[Authorize]
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
        ///  Get genres
        ///</summary>
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        /// <param name="bookGenreId"> The id of the bookgenre</param>
        /// <param name="genre"> The name of the bookgenre</param>
        ///<response code="200">Returns different bookgenres</response>



        [HttpGet]
        [Route("genres")]
        [MapToApiVersion("2.0")]
        public async Task<ActionResult<List<BookGenre>>> GetGenres()
        {
            try
            {
                return new OkObjectResult(await _registrationService.GetGenres());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return new StatusCodeResult(500);
            }
        }
        // {
        //     return await _registrationService.GetGenres();
        // }

        ///<summary>
        ///  Get genres
        ///</summary>
        [HttpGet]
        [Route("genres")]
        public async Task<ActionResult<List<BookGenreDTO>>> GetGenresDTO()
        {
            try
            {
                return new OkObjectResult(await _registrationService.GetGenresDTO());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }





        ///<summary>
        ///  Get suppliers
        ///</summary>

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        /// <param name="supplierId"> The id of the supplier</param>
        /// <param name="name"> The name of the supplier</param>
        ///<response code="200">Returns different suppliers</response>

        [HttpGet]
        [Route("suppliers")]
        [MapToApiVersion("2.0")]
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
        ///  Get suppliers
        ///</summary>
        [HttpGet]
        [Route("suppliers")]

        public async Task<ActionResult<List<Supplier>>> GetSuppliersDTO()
        {
            try
            {
                return new OkObjectResult(await _registrationService.GetSuppliersDTO());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }


        ///<summary>
        ///  Get authors
        ///</summary>

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        /// <param name="authorId"> The id of the author</param>
        /// <param name="name"> The name of the author</param>
        /// <param name="age"> The age of the author</param>
        /// <param name="country"> The country of the author</param>
        ///<response code="200">Returns different authors</response>

        [Authorize]
        [HttpGet]
        [Route("authors")]
        [MapToApiVersion("2.0")]



        public async Task<ActionResult<List<Author>>> GetAuthors()
        {


            try
            {
                return new OkObjectResult(await _registrationService.GetAuthors());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }

        }


        ///<summary>
        ///  Get authors dto
        ///</summary>
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
        ///  Get books
        ///</summary>

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        /// <param name="bookId"> The id of the book</param>
        /// <param name="title"> The title of the book</param>
        /// <param name="description"> The description of the book</param>
        /// <param name="year"> The year of the book</param>
        /// <param name="authorId"> The id of the author</param>
        ///<response code="200">Returns different books</response>

        [HttpGet]
        [Route("books")]
        [MapToApiVersion("2.0")]

        public async Task<ActionResult<List<Book>>> GetBooks(string title = "", bool includeAuthor = false)
        {
            try
            {
                return new OkObjectResult(await _registrationService.GetBooks(includeAuthor));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }

        }

        ///<summary>
        ///  Get BooksDTO
        ///</summary>
        [HttpGet]
        [Route("books")]

        public async Task<ActionResult<List<Supplier>>> GetBooksDTO(bool includeAuthor = false)
        {
            try
            {
                return new OkObjectResult(await _registrationService.GetBooksDTO(includeAuthor));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }





        ///<summary>
        ///  Post a book
        ///</summary>

        [ProducesResponseType(StatusCodes.Status404NotFound)]

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
