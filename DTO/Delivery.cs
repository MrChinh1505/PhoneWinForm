using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Delivery
    {
       

        public int id {get; set;}
        public string orderID { get; set;}
        public string AgentID { get; set;}
        public string paymentStatus { get;set;}
        public string deliveryStatus { get;set;}

        public Delivery(int ID, string oID,  string agentID, string ps, string ds)
        {
            id = id;
            orderID = oID;
            paymentStatus = ps;
            deliveryStatus = ds;
            AgentID = agentID;
        }
    }
}
