using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string supplier { get; set; }
        public string price { get; set; }

        public Product(string id, string name, string supplier, string price) {
            this.id = id;
            this.name = name;
            this.supplier = supplier;
            this.price = price;
        }
    }
}
