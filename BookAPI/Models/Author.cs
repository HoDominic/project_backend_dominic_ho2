using System;

namespace BookAPI.Models
{
    public class Author
    {
        ///<summary>
        ///   Author with AuthorId,Name,Age and Country
        ///</summary>
        public Guid AuthorId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }
    }
}
