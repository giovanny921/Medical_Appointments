using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas.Models
{
    internal class Connection
    {
        public static MySqlConnection connection()
        {
            string server = "localhost";
            string database = "medical_appointments";
            string user = "root";
            string password = "Colombia23*";

            string sqlSentence = $"Database={database}; Data Source={server}; User Id={user}; Password={password}";
            try 
            {
                MySqlConnection connectionDB = new MySqlConnection(sqlSentence); 
                return connectionDB;
            }
            catch(MySqlException exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }
    }
}
