using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_System_BL
{
	class DBMySQLUtils
	{
		public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database + ";port="
            	+ port + ";User Id=" + username + ";password=" + password;
 
            MySqlConnection conn = new MySqlConnection(connString);
 
            return conn;
        }
	}
}
