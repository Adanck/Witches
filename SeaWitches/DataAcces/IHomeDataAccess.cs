using SeaWitches.Models;

namespace SeaWitches.DataAcces
{
    public interface IHomeDataAccess
    {
        public HomeModel GetHome();

        public UserModel GetUsers();

        public ListProjectsModel GetProjects();

        public ContactsModel GetContacts();

        public ListBlogModel GetBlogs();

        public ListActivitiesModel GetActivities();

        public PageModel GetAllPage();
    }
}
