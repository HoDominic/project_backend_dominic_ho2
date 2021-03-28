using System;
using System.ComponentModel.DataAnnotations;

namespace BookAPI.DTO
{
    public class AuthorDTO
    {

        [Key]
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
    }
}
