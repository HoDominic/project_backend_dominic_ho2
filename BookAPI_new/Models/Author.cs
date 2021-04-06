using System;

namespace BookAPI.Models
{

    /// <summary>
    /// An author with AuthorId, Name, Age and Country field.
    /// </summary>


    public class Author
    {
        public Guid AuthorId { get; set; }


        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }
    }
}
