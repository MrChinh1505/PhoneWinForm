using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo : Database
    {
        public OrderRepo() :base()
        {
        }

        public DataTable getTop(int top)
        {

            string s = $"SELECT TOP {top} p.ProductName, SUM(od.Quan) as TotalQuantity " +
           $"FROM OrderDetail od " +
           $"JOIN Product p ON od.ProductID = p.ProductID " +
           $"GROUP BY p.ProductID, p.ProductName " +
           $"ORDER BY TotalQuantity DESC";

            return query(s);
        }

        public DataTable find(string id)
        {
            return query("SELECT * FROM OrderTable WHHERE OrderID = {id}");
        }

        public DataTable findAll()
        {
            return query("SELECT * FROM OrderTable");
        }
        
        public DataTable findDetail()
        {
            return query("SELECT * FROM OrderDetail");
        }

        public void save(Order o)
        {
            string s = $"INSERT INTO OrderTable (OrderID, DateOrdered, AgentID, Total) VALUES ('{o.id}', '{o.date}', '{o.agentName}', {o.total})";
            noneQuery(s);
        }
        public void saveDetail(string id ,string pid, string q, string price)
        {
            string s = $"INSERT INTO OrderDetail (OrderID, ProductID, Quan, Price)VALUES ('{id}', '{pid}', {q}, {price})";
            noneQuery(s);
        }

        public void delete(string id)
        {
            string s = "";
            noneQuery(s);
        }
    }
}
