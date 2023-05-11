using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepo : Database
    {
        public EmployeeRepo(): base() { 
        }
        public bool auth(string username,string  password)
        {
            DataTable dt = query($"SELECT * FROM Employee WHERE EmployeeID = '{username}' AND Password = '{password}'");
            return dt.Rows.Count > 0 ? true : false;
        }
    }
}
