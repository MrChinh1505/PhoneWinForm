using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AgentRepo
    {
        private Database _instance;
        public AgentRepo()
        {
            _instance = new Database();
        }
        public DataTable findById(string id)
        {
            // select by id
            string s = $"SELECT * FROM Agent WHERE AgentID='{id}'";
            return _instance.query(s);
        }
        public DataTable findAll()
        {
            // select all
            string s = "SELECT * FROM Agent";
            return _instance.query(s);
        }
        public DataTable SortIdByDesc()
        {
            return null;
        }

        public void save(Agent a)
        {
            // insert 
            string s = $"INSERT INTO Agent(AgentID, AgentName, Address, Contact, Password) VALUES ('{a.AgentID}', '{a.AgentName}', '{a.Address}', '{a.Contact}', '{a.Password}')";
            _instance.noneQuery(s);
        }
        public void saveChanges(Agent a)
        {
            // update
            string s = $"UPDATE Agent " +
                $"SET AgentName= '{a.AgentName}', Address= '{a.Address}' , Contact = '{a.Contact}', Password = '{a.Password}'" +
                $"WHERE AgentID = '{a.AgentID}'";
            _instance.noneQuery(s);
        }

        public void delete(string id)
        {
            // update
            string s = $"DELETE FROM Agent WHERE AgentID = '{id}'";
            _instance.noneQuery(s);
        }

        public void delete_all()
        {
            // update
            string s = $"DELETE FROM Agent";
            _instance.noneQuery(s);
        }
    }
}
