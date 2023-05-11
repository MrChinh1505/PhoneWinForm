using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        public string id { get; set; }
        public string agentName { get; set; }
        public string date { get; set; }
        public string total { get; set; }
        public Order(string id, string agentName, string date,string total) {
            this.id = id;
            this.agentName = agentName;
            this.date = date;
            this.total = total;
        }
    }
}
