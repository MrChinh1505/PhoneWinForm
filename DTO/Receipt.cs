using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Receipt
    {
        public string id { set; get; }
        public string supplier { set; get; }
        public string date { set; get; }

        public string total { set; get; }

        public Receipt(string id , string supplier, string date, string total)
        {
            this.id = id;
            this.supplier = supplier;
            this.date = date;
            this.total = total;
        }
    }
}
