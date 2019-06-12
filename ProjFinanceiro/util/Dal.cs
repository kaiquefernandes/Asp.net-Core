using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjFinanceiro.util
{


    public class Dal
    {
        private static string server = "localhost";
        private static string database = "financeiro";
        private static string user = "root";
        private static string password = "";
        private  string connectionString = $"Server={server}; DataBase={database}; Uid={user}; Pwd={password}";
        private MySqlConnection connection;

        public Dal(){

        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        }

        public DataTable RetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dataTable);
            return dataTable;
        }

        public void executaSql(string sql)
        {
            MySqlCommand com = new MySqlCommand(sql, connection);
            com.ExecuteNonQuery();
        }

    }
}
