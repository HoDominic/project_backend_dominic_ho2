using System;
using System.Collections.Generic;

namespace BookAPI.Models
{
    public class BookSupplier
    {
        public Guid BookId { get; set; }

        public Book Book { get; set; }

        public int SupplierId { get; set; }


        public Supplier Supplier { get; set; }
    }
}
