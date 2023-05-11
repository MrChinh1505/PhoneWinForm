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
    public class ProductService
    {
        // create repo 
        private ProductRepo repo = new ProductRepo();
        //

        public ProductService()
        {
            
        }

        public string generateID()
        {

            DataTable maxID = repo.SortIdByDesc();
            return null;
        }

        public DataTable allSupplier()
        {
            return repo.findAllSupplier();
        }
        
        public void save(Product p , Inventory i)
        {
            //this.p.id = generateID();
            repo.save(p, i);
        }
        public void save(Product p)
        {
            //this.p.id = generateID();
            repo.save(p);
        }

        public DataTable find(string id)
        {
            return repo.findByid(id);
        }

        public void update(Product p, Inventory i)
        {
            repo.saveChanges(p, i);
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
            repo.deleteAll();
        }
    }
}
