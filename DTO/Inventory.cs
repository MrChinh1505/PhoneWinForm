using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Inventory
    {
        public string OnOrder { get; set; }   
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string instock { get;set; }
        public string importPrice { get; set; }
        public Inventory(string Onder, string mini, string max , string stoc, string importPrice)
        {
            this.OnOrder = Onder;
            this.minimum = mini;
            this.maximum = max;
            this.instock = stoc;
            this.importPrice = importPrice;
        }
    }
}
