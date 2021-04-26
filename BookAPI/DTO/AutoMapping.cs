using System;
using AutoMapper;
using BookAPI.Models;

namespace BookAPI.DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Author, AuthorDTO>();
        }
    }
}
