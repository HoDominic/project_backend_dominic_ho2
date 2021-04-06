using System;
using System.ComponentModel.DataAnnotations;

namespace BookAPI.Models
{

    /// <summary>
    /// A bookgenre with BookGenreId and Genre field. 
    /// </summary>
    public class BookGenre
    {
        public Guid BookGenreId { get; set; }


        [MaxLength(150)]
        public string Genre { get; set; }
    }
}
