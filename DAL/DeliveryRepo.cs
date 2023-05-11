using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliveryRepo : Database
    {
        public DeliveryRepo():base() { 

        }
        public void update(Delivery _d)
        {
            string s = $"UPDATE Delivery " + 
                        $" SET paymentStatus = '{_d.paymentStatus}', deliverStatus = '{_d.deliveryStatus}' " + 
                        $" WHERE OrderID = '{_d.orderID}'";
            noneQuery(s);
        }

        public void create(Delivery _d)
        {
            string s = $"INSERT INTO Delivery (OrderID, paymentStatus, deliverStatus) VALUES ('{_d.orderID}', '{_d.paymentStatus}', '{_d.deliveryStatus}');";
            noneQuery(s);
            noneQuery("");
        }

        public DataTable find()
        {
            string s = @"SELECT Delivery.deliveryID, OrderTable.OrderID, OrderTable.DateOrdered,
                         OrderTable.AgentID, OrderTable.Total, Delivery.paymentStatus, Delivery.deliverStatus
                         FROM Delivery INNER JOIN OrderTable ON Delivery.OrderID = OrderTable.OrderID";
            return query(s);
        }
        public DataTable find(string id)
        {
            string s = $"SELECT Delivery.deliveryID, OrderTable.OrderID, OrderTable.DateOrdered, OrderTable.AgentID, OrderTable.Total, Delivery.paymentStatus, Delivery.deliverStatus" + 
                $" FROM Delivery INNER JOIN OrderTable ON Delivery.OrderID = OrderTable.OrderID WHERE OrderTable.OrderID = '{id}'";
            return query(s);
        }
    }
}
