using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace StudentManagmentSystem
{
    /*
     * 
     */
    internal class DBconnect
    {
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Sifra.za.sql;database=studentdb");

        //to get connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }
        // create a function to open connection
        public void openConnect()
        {
            if (connect.State==System.Data.ConnectionState.Closed)
                connect.Open();
        }
        //create a function to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
