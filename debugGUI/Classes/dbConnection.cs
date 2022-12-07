using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Navigation;

namespace debugGUI.Classes
{
    internal class dbConnection
    {
        // change connection string here to get access to the DB on your local
        string ConnectionString = @"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True";
        public SqlConnection DBConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            conn.Close();
            return conn;
        }
    }
}
