using System;
using System.Collections.Generic;

namespace BookAPI.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        public string Name { get; set; }

        public List<BookSupplier> BookSuppliers { get; set; }
    }
}
