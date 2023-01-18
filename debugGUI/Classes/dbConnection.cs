using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace debugGUI.classes
{
    public class dbConnection
    {
        // change connection string here to get access to the DB on your local machine
        public string ConnectionString = @"Data Source=LAPTOP-6K52544T;Initial Catalog=rayco;Integrated Security=True";

        public dbConnection()
        {
          
        }

        public string StringFunction()
        {
            return ConnectionString;
        }
      
     
    }
}
