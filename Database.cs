using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Database
    {
        private string server = "localhost";
        private string user = "root";
        private string password = "root";
        private string port = "3306";
        private string database = "bankomat";
        private MySqlConnection conn;


        public void openConnection()
        {
            string conStr = "server=" + server +
                      ";user=" + user +
                      ";database=" + database +
                      ";port=" + port +
                      ";password=" + password + ";";
            conn = new MySqlConnection(conStr);

            if (conn == null) Console.WriteLine("error");
            else Console.WriteLine("ok");
        }

        internal int checkPIN(string code)
        {
             
            string q = "SELECT counter FROM cards WHERE pin LIKE"+ code;

            MySqlCommand com = new MySqlCommand(q);
            MySqlDataReader r = com.ExecuteReader();
            if (r.Read())
            {
                Console.WriteLine("ok");

            }
            return 0;
        }
    }
}
