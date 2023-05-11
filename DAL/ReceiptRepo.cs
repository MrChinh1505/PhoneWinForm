using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceiptRepo : Database
    {
        public ReceiptRepo() : base() {
        }

        public DataTable supplier()
        {
            return query("SELECT * FROM Supplier");
        }

        public DataTable findReceiptID(string id)
        {
            return query($"SELECT * FROM ImportTable WHERE ImportID = '{id}'");
        }

        public DataTable findProductByReceiptId(string id)
        {
            return query($"SELECT * FROM ImportDetailTable WHERE ImportID = '{id}'");
        }

        public DataTable findAll()
        {
            return query("SELECT * FROM ImportTable");
        }

        public DataTable bestProduct() 
        {
            return query("SELECT TOP 10 \n    p.ProductName, \n    SUM(od.Quan) AS TotalQuantity\nFROM \n    Product p\n    INNER JOIN OrderDetail od ON p.ProductID = od.ProductID\nGROUP BY \n    p.ProductName\nORDER BY \n    TotalQuantity DESC;");
        }

        public void save(Receipt r)
        {
            noneQuery($"INSERT INTO ImportTable VALUES ('{r.id}', '{r.date}', '{r.supplier}',{r.total})");
        }

        public void saveDetail(string rID, string pID, string quan ,string price)
        {
            noneQuery($"INSERT INTO ImportDetailTable VALUES ('{rID}', '{pID}', {quan}, {price})");
        }


        public void delete(string id)
        {
            query($"DELETE FROM ImportTable WHERE ImportID = '{id}'");
            query($"DELETE FROM ImportDetailTable WHERE ImportID = '{id}'");
        }
    }
}
