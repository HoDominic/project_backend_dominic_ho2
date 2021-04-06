using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookAPI.Data;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Repositories
{
    public interface IAuthorRepository
    {
        Task<List<Author>> GetAuthors();
    }

    public class AuthorRepository : IAuthorRepository
    {

        private IRegistrationContext _context;
        public AuthorRepository(IRegistrationContext context)
        {
            _context = context;
        }



        public async Task<List<Author>> GetAuthors()
        {
            return await _context.Authors.ToListAsync();
        }
    }
}
