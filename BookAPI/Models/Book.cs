using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BookAPI.Models
{
    ///<summary>
    ///   Book with BookId ,Title, Description, Year,AuthorId,BookGenreId 
    ///</summary>
    public class Book
    {
        public Guid BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        public Author Author { get; set; }

        [Required]
        public Guid BookGenreId { get; set; }


        [JsonIgnore]
        public ICollection<BookSupplier> BookSuppliers { get; set; }



    }
}
