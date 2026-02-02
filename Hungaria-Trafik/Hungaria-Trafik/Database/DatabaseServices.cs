using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hungaria_Trafik.DataBase
{
    internal class DatabaseServices
    {
        private static string connectionString;
        private static string table;
        private static string queryParameters;

        public static void connectionCheck(string connectionString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Sikeresen csatlakoztál a trafik adatbázisához!");
                }


            }
            catch (Exception error)
            {

                Console.WriteLine(error);
            }
        }
    }
}