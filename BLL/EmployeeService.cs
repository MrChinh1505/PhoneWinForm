using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeService
    {
        private EmployeeRepo repo = new EmployeeRepo();


        public bool login(string username, string password)
        {
            return repo.auth(username, password);
        }
    }
}
