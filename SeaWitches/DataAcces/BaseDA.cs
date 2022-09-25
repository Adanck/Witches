using Microsoft.Data.Sqlite;

namespace SeaWitches.DataAcces
{
    public class BaseDA
    {
        private static string? connectionString { get; set; }

        public static string GetConnectionString()
        {
            string pathDataBase = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"", "DataBase\\WitchesData.db");
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = pathDataBase };
            var connectionString = connectionStringBuilder.ToString();
            return connectionString;
        }
    }
}
