using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace debugGUI.Classes
{
    internal class dbConnection
    {
        // change connection string here to get access to the DB on your local machine
        private string ConnectionString = @"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True";

        public SqlConnection conn = new SqlConnection();
        public string querry;
        public string commandString;

        public string teststring = "TEST STRING";

        public dbConnection()
        {
           conn = new SqlConnection(ConnectionString);
        }

        // open sql connection
        public void connOpen()
        {
            conn.Open();
        }

        // close opened sql connection
        public void connClose()
        {
            conn.Close();
        }

        // pass along sql querry with sql adapter for datatable fill
        public object sqlQ(string Qstring)
        {
            querry = Qstring;
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            return sda;
        }

        // sql statement method
        public SqlCommand sqlComm(string cstr)
        {
            SqlConnection sqlConnection = new SqlConnection(cstr);
            commandString = cstr;
            SqlCommand command = new SqlCommand(commandString, sqlConnection);
            return command;
        }

        // test function
        public void Test()
        {
            Console.WriteLine(teststring);
        }
    }
}
