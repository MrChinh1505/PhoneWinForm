using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo : Database
    {
        public ProductRepo() : base(){
        }
        public void save(Product p, Inventory i)
        {
            string pCmd = $"INSERT INTO [final_se].[dbo].[Product] ( " +
                $"[ProductID], [ProductName], [Price], [Supplier])" +
                $" VALUES ('{p.id}','{p.name}','{p.price}','{p.supplier}' )";

            string iCmd = $"INSERT INTO [final_se].[dbo].[Inventory] ( " +
                $"[ProductID], [InStock], [OnOrder], [MinimumStockLevel], [MaximumStockLevel], [ImportPrice])" +
                $" VALUES ('{p.id}',{i.instock}, {i.OnOrder}, {i.minimum}, {i.maximum} ,{i.importPrice}) ";

            // execute query
            this.noneQuery(pCmd);
            this.noneQuery(iCmd);
        }
        public void save(Product p)
        {
            string pCmd = $"INSERT INTO [final_se].[dbo].[Product] ( " +
                $"[ProductID], [ProductName], [Price], [Supplier])" +
                $" VALUES ('{p.id}','{p.name}','{p.price}','{p.supplier}' )";

            // execute query
            this.noneQuery(pCmd);
        }
        public void saveChanges(Product p, Inventory i)
        {
            // Update row in table 
            string pCmd = $"UPDATE [final_se].[dbo].[Product] " +
                $"SET [Price] = '{p.price}', [ProductName] = '{p.name}', [Supplier] = '{p.supplier}'" +
                $"WHERE [ProductID] = '{p.id}'"; 

            string iCmd = $"UPDATE [final_se].[dbo].[Inventory] " +
                $"SET [InStock] = {i.instock}, [OnOrder] = {i.OnOrder}, [MinimumStockLevel] = {i.minimum}, [MaximumStockLevel]={i.maximum}, [ImportPrice]={i.importPrice}" +
                $"WHERE [ProductID] = '{p.id}'";

            // execute query
            this.noneQuery(pCmd);
            this.noneQuery(iCmd);
        }

        public void delete(string id)
        {
            // Delete row in table 
            string pCmd = $"DELETE FROM Product WHERE ProductID = '{id}'";
            string iCmd = $"DELETE FROM Inventory WHERE ProductID = '{id}'";

            // execute query
            this.noneQuery(pCmd);
            this.noneQuery(iCmd);
        }

        public void deleteAll()
        {
            string pCmd = $"DELETE FROM Product";
            this.noneQuery(pCmd);
        }

        public DataTable findByid(string id)
        {
            // get all information from two table inventory and product with product id
            //string fCmd = $"SELECT Product.ProductID ,ProductName,Price,Inventory.ImportPrice, Supplier,InStock,OnOrder,MinimumStockLevel,MaximumStockLevel FROM Product " +
            //    $"INNER JOIN Inventory ON Product.ProductID = Inventory.ProductID " +
            //    $"WHERE Product.ProductID = '{id}'";
            string fCmd = $"SELECT * FROM Product " +
                $"WHERE ProductID = '{id}'";

            // execute query
            return this.query(fCmd);
        }

        // 
        public DataTable findAllSupplier()
        {
            string s = "SELECT * FROM SUPPLIER";
            return this.query(s);
        }


        // for generate ID 
        public DataTable SortIdByDesc()
        {
            return null;
        }

        public DataTable findAll()
        {
            // get all information and all products from two table inventory and product
            //string fCmd = @"SELECT Product.ProductID ,ProductName,Price,Inventory.ImportPrice,InStock,OnOrder, Supplier,MinimumStockLevel,MaximumStockLevel
            //                FROM Product
            //                INNER JOIN Inventory
            //                ON Product.ProductID = Inventory.ProductID
            //                WHERE Product.ProductID = Inventory.ProductID";
            string fCmd = @"SELECT * FROM Product";
            // execute query
            return this.query(fCmd);
        }
    }
}
