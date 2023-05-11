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
    public class OrderService
    {
        OrderRepo or = new OrderRepo();
        public OrderService()
        {

        }
        public DataTable find(string id)
        {
            return or.find(id);
        }
        public DataTable findAllProductFromOrderID(string id)
        {
            return or.findDetail();
        }

        public DataTable TopSeller(int top)
        {
            return or.getTop(top);
        }

        public DataTable findAll()
        {
            return or.findAll();
        }

        public void save(Order o)
        {
            or.save(o);
        }

        public void saveDetail(string orID, string pID, string quan, string price)
        {
            or.saveDetail(orID, pID ,quan, price);
        }

        public void delete(string id)
        {
            or.delete(id);
        }
    }
}
