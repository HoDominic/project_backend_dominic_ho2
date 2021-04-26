using System;
using BookAPI.Models;

namespace BookAPI.DTO
{
    public class BookDTO
    {
        public Guid BookId { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }
    }
}
