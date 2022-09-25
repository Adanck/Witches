using Microsoft.Data.Sqlite;
using SeaWitches.Models;

namespace SeaWitches.DataAcces
{
    public class HomeDataAccess : BaseDA, IHomeDataAccess
    {
        public HomeModel GetHome()
        {
            try
            {
                using (SqliteConnection sql_con = new SqliteConnection(GetConnectionString()))
                {
                   // sql_con.Open();
                    using (SqliteCommand sql_cmd = new SqliteCommand() )
                    {
                        sql_cmd.CommandText = "select * from Users";
                        sql_cmd.Connection = sql_con;
                        sql_cmd.Connection.Open();
                        sql_cmd.Prepare();


                        SqliteDataReader reader = sql_cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string username = (string)reader[1];
                            int id = Convert.ToInt32(reader[0]);
                        }
                    }
                }
                return new HomeModel();
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
        }
    }

}


