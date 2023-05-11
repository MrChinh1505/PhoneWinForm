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
    public  class ReceiptService
    {
        private ReceiptRepo re = new ReceiptRepo();
        public ReceiptService() { 
        } 

        public DataTable SupplierList()
        {
            return re.supplier();
        }

        public DataTable findAll()
        {
            return re.findAll();
        }

        public DataTable findByReceiptId(string id)
        {
            return re.findReceiptID(id);
        }

        public DataTable findProductByReceiptId(string  id)
        {
            return re.findProductByReceiptId(id);
        }

        public void save(Receipt r)
        {
            re.save(r);
        }

        public void saveDetail(string rID, string pID, string quan, string price)
        {
            re.saveDetail(rID, pID, quan, price);
        }

        public void delete(string id)
        {
            re.delete(id);
        }
    }
}
