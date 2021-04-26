using System;
using AutoMapper;
using BookAPI.Models;

namespace BookAPI.DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Supplier, SupplierDTO>();
            CreateMap<Book, BookDTO>();
            CreateMap<BookGenre, BookGenreDTO>();
            // CreateMap<Author, AuthorDTO>();
        }
    }
}
