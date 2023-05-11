using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Agent
    {
        public string AgentID { get; set; }
        public string AgentName { get; set; }
        public string Address { get;set; }
        public string Contact { get; set; }
        public string Password { get; set; }
        public Agent(string id, string name, string add , string contact, string password)
        {
            this.AgentName = name;
            this.AgentID = id;
            this.Address = add;
            this.Contact = contact;
            this.Password = password;
        }
    }
}
