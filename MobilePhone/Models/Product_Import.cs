using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Models
{
    public class Product_Import
    {
        public Product_Import(string id, string name, string supplier, string price, string onOrder, string minimum, string maximum, string instock, string importPrice)
        {
            this.id = id;
            this.name = name;
            this.supplier = supplier;
            this.price = price;
            this.OnOrder = onOrder;
            this.minimum = minimum;
            this.maximum = maximum;
            this.instock = instock;
            this.importPrice = importPrice;
        }

        public string id { get; set; }
        public string name { get; set; }
        public string supplier { get; set; }
        public string price { get; set; }

        public string OnOrder { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string instock { get; set; }
        public string importPrice { get; set; }
    }

}
