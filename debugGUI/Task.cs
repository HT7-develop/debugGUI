using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace debugGUI
{
    internal class Task
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True");

        //function for creating new tasks
        public void CreateTask()
        {

        }

        //function for retrieving tasks 
       public void GetTasks()
        {
            conn.Open();
            String querry = "SELECT * FROM tasks";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
        }
    }
}
