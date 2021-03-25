using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_System_BL
{

	class DBUtils
	{
		 public static MySqlConnection GetDBConnection( )
        {
            const string host = "localhost";
            const int port = 3306;
            const string database = "library_db";
            const string username = "root";
            const string password = "zntu";
 
            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
	}
}
