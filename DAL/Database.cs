using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        private string _dbConnectionString;
        private SqlConnection _con;

        public Database() {
            _dbConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=final_se;Integrated Security=True";
            _con = new SqlConnection(_dbConnectionString);
            _con.Open();
        }

        public DataTable query(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, _con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public void noneQuery(string sql)
        {
           SqlCommand _command = new SqlCommand(sql, _con);
            _command.ExecuteNonQuery();
        }
    }
}
