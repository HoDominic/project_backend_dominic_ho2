using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BookAPI.Models
{


    ///<summary>
    ///  Supplier with SupplierId and Name
    ///</summary>
    public class Supplier
    {
        public int SupplierId { get; set; }

        public string Name { get; set; }


        [JsonIgnore]
        public ICollection<BookSupplier> BookSuppliers { get; set; }
    }
}
