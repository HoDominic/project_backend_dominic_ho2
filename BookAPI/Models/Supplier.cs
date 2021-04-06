using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BookAPI.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        public string Name { get; set; }


        [JsonIgnore]
        public List<BookSupplier> BookSuppliers { get; set; }
    }
}
