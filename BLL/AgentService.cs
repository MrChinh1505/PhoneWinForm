using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgentService
    {
        // create repo 
        private AgentRepo repo = new AgentRepo();

        public AgentService()
        {

        }

        public string generateID()
        {

            DataTable maxID = repo.SortIdByDesc();
            return null;
        }

        public void save(Agent a)
        {
            //this.p.id = generateID();
            repo.save(a);
        }

        public void saveChange(Agent a)
        {
            repo.saveChanges(a);
        }

        public DataTable find(string id)
        {
            return repo.findById(id);
        }

        public void update(Agent a)
        {
            repo.saveChanges(a);
        }

        public DataTable getAll()
        {
            return repo.findAll();
        }

        public void delete(string id)
        {
            repo.delete(id);
        }

        public void delete_all()
        {
            repo.delete_all();
        }
    }
}
