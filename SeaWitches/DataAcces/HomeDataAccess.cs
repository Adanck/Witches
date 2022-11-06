using Microsoft.Data.Sqlite;
using SeaWitches.Models;

namespace SeaWitches.DataAcces
{
    public class HomeDataAccess : BaseDA, IHomeDataAccess
    {
        public ListActivitiesModel GetActivities()
        {
            try
            {
                var response = new ListActivitiesModel();
                using (SqliteConnection sql_con = new SqliteConnection(GetConnectionString()))
                {
                    using (SqliteCommand sql_cmd = new SqliteCommand())
                    {
                        sql_cmd.CommandText = "select * from Activities";
                        sql_cmd.Connection = sql_con;
                        sql_cmd.Connection.Open();
                        sql_cmd.Prepare();


                        SqliteDataReader reader = sql_cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var act = new ActivitiesModel();
                            act.Name =  (string)reader["Name"];
                            act.Description =  (string)reader["Description"];
                            act.Author =  (string)reader["Author"];
                            act.Video = (byte[])reader["Video"];
                            act.Date = (DateTime)reader["Date"];
                            response.List.Add(act);
                        }
                    }
                }
                return response;
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
        }

        public ListBlogModel GetBlogs()
        {
            try
            {
                var response = new ListBlogModel();
                using (SqliteConnection sql_con = new SqliteConnection(GetConnectionString()))
                {
                    using (SqliteCommand sql_cmd = new SqliteCommand())
                    {
                        sql_cmd.CommandText = "select * from Blog";
                        sql_cmd.Connection = sql_con;
                        sql_cmd.Connection.Open();
                        sql_cmd.Prepare();


                        SqliteDataReader reader = sql_cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var act = new BlogsModel();
                            act.Name = (string)reader["Name"];
                            act.Description = (string)reader["Description"];
                            act.Author = (string)reader["Author"];
                            act.Image = (byte[])reader["Image"];
                            response.ListBlog.Add(act);
                        }
                    }
                }
                return response;
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
        }

        public ContactsModel GetContacts()
        {
            try
            {
                var response = new ContactsModel();
                using (SqliteConnection sql_con = new SqliteConnection(GetConnectionString()))
                {
                    using (SqliteCommand sql_cmd = new SqliteCommand())
                    {
                        sql_cmd.CommandText = "select * from Contacts";
                        sql_cmd.Connection = sql_con;
                        sql_cmd.Connection.Open();
                        sql_cmd.Prepare();

                        SqliteDataReader reader = sql_cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            response.Facebook = reader["Facebook"].ToString();
                            response.Instagram = reader["Instagram"].ToString();
                            response.WhatsApp = reader["WhatsApp"].ToString();
                            response.Telegram = reader["Telegram"].ToString();
                            response.Twitter = reader["Twitter"].ToString();
                            response.Email = reader["Email"].ToString();
                            response.Phone1 = reader["PhoneNumber"].ToString();
                            response.Phone2 = reader["PhoneNumber2"].ToString();
                        }
                    }
                }
                return response;
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
        }

        public List<SpecificObjectives> GetObjectivesSpecific() {
            try
            {
                var response = new List<SpecificObjectives>();
                using (SqliteConnection sql_con = new SqliteConnection(GetConnectionString()))
                {
                    using (SqliteCommand sql_cmd = new SqliteCommand())
                    {
                        sql_cmd.CommandText = "select * from SpecificObjectives";
                        sql_cmd.Connection = sql_con;
                        sql_cmd.Connection.Open();
                        sql_cmd.Prepare();

                        SqliteDataReader reader = sql_cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var objective = new SpecificObjectives();
                            objective.Description = reader["Description"].ToString();
                            response.Add(objective);
                        }
                    }
                }
                return response;
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
        }

        public HomeModel GetHome()
        {
            try
            {
                var response = new HomeModel();
                using (SqliteConnection sql_con = new SqliteConnection(GetConnectionString()))
                {
                    using (SqliteCommand sql_cmd = new SqliteCommand() )
                    {
                        sql_cmd.CommandText = "select * from Home";
                        sql_cmd.Connection = sql_con;
                        sql_cmd.Connection.Open();
                        sql_cmd.Prepare();

                        SqliteDataReader reader = sql_cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            response.About = reader["About"].ToString();
                            response.Vision = reader["Vision"].ToString();
                            response.Mision = reader["Mision"].ToString();
                            response.GeneralObjective = reader["GeneralObjective"].ToString();
                            response.History = reader["History"].ToString();
                            response.OrganizationalStructure = reader["OrganizationalStructure"].ToString();
                        }
                    }
                }
                return response;
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
        }

        public ListProjectsModel GetProjects()
        {
            try
            {
                var response = new ListProjectsModel();
                using (SqliteConnection sql_con = new SqliteConnection(GetConnectionString()))
                {
                    using (SqliteCommand sql_cmd = new SqliteCommand())
                    {
                        sql_cmd.CommandText = "select * from Projects";
                        sql_cmd.Connection = sql_con;
                        sql_cmd.Connection.Open();
                        sql_cmd.Prepare();

                        SqliteDataReader reader = sql_cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var project = new ProjectsModel();
                            project.Name = (string)reader["Name"];
                            project.Description = (string)reader["Description"];
                            project.Objectives = (string)reader["Objectives"];
                            project.Image = (byte[])reader["Image"];
                            project.Author = (string)reader["Author"];

                        }
                    }
                }
                return response;
            }
            catch (SqliteException ex)
            {
                throw ex;
            }
        }

        public UserModel GetUsers()
        {
            throw new NotImplementedException();
        }
        
        public PageModel GetAllPage()
        {
            var response = new PageModel();
            response.Home = GetHome();
            response.Activities = GetActivities();
            response.Contacts = GetContacts();
            response.Blogs = GetBlogs();
            response.Projects = GetProjects();
            response.SpecificObjectives = GetObjectivesSpecific();
            return response;
        }
    }

}


