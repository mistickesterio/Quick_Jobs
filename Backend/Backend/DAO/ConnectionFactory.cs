using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Backend.DAO
{
	public class ConnectionFactory
	{
		public static MySqlConnection Build()
		{
			string connectionString = "Server=localhost;Database=QuickJobs;Uid=root;Pwd=root;";
			return new MySqlConnection(connectionString);
		}
	}
}
