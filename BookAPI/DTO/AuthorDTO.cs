using System;
using System.ComponentModel.DataAnnotations;

namespace BookAPI.DTO
{
    public class AuthorDTO
    {

        //public Guid AuthorId { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
