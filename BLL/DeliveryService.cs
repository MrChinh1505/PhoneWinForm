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
    public class DeliveryService
    {
        private DeliveryRepo deliveryRepo;
        public DeliveryService() {
            deliveryRepo = new DeliveryRepo();
        }
        public DataTable find()
        {
            return deliveryRepo.find();
        }

        public DataTable find(string id)
        {
            return deliveryRepo.find(id);
        }

        public void update(string orderID, string aID ,string ps, string ds )
        {
            deliveryRepo.update(new Delivery(0,orderID,aID, ps,ds)) ;
        }
        
        public void create(string orderID, string aID ,string ps, string ds)
        {
            deliveryRepo.create(new Delivery(0, orderID, aID, ps, ds));
        }
    }
}
