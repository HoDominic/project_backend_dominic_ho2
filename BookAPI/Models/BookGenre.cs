using System;

namespace BookAPI.Models
{

    /// <summary>
    /// A bookgenre with BookGenreId and Genre field. 
    /// </summary>
    public class BookGenre
    {
        public Guid BookGenreId { get; set; }

        public string Genre { get; set; }
    }
}
