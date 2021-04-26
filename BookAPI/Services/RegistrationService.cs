using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BookAPI.DTO;
using BookAPI.Models;
using BookAPI.Repositories;

namespace BookAPI.Services
{
    public interface IRegistrationService
    {
        Task<Book> AddBook(Book book);
        Task<Book> DeleteBook(Book book);
        Task<List<Author>> GetAuthors();

        Task<List<AuthorDTO>> GetAuthorsDTO();




        Task<List<Book>> GetBooks(bool includeAuthor);
        Task<List<BookGenre>> GetGenres();

        Task<List<Supplier>> GetSuppliers();

    }

    public class RegistrationService : IRegistrationService
    {

        private IAuthorRepository _authorRepository;

        //private IAuthorDTORepository _authorDTORepository;
        private IBookGenreRepository _bookGenreRepository;
        private IBookRepository _bookRepository;

        private ISupplierRepository _supplierRepository;

        private IMapper _mapper;

        public RegistrationService(IMapper mapper,
        IAuthorRepository authorRepository,
        //IAuthorDTORepository authorDTORepository,
        IBookGenreRepository bookGenreRepository,
        IBookRepository bookRepository,
        ISupplierRepository supplierRepository
        )
        {
            _authorRepository = authorRepository;
            //_authorDTORepository = authorDTORepository;

            _bookGenreRepository = bookGenreRepository;
            _bookRepository = bookRepository;
            _supplierRepository = supplierRepository;

            _mapper = mapper;

        }



        public async Task<List<Author>> GetAuthors()
        {
            return await _authorRepository.GetAuthors();
        }


        public async Task<List<AuthorDTO>> GetAuthorsDTO()
        {
            return _mapper.Map<List<AuthorDTO>>(await _authorRepository.GetAuthors());
        }




        public async Task<List<BookGenre>> GetGenres()
        {
            return await _bookGenreRepository.GetGenres();
        }

        public async Task<List<Supplier>> GetSuppliers()
        {
            return await _supplierRepository.GetSuppliers();
        }


        public async Task<List<Book>> GetBooks(bool includeAuthor)
        {
            return await _bookRepository.GetBooks(includeAuthor);
        }

        public async Task<Book> AddBook(Book book)
        {
            return await _bookRepository.AddBook(book);
        }





        public async Task<Book> DeleteBook(Book book)
        {
            return await _bookRepository.DeleteBook(book);
        }


    }
}
