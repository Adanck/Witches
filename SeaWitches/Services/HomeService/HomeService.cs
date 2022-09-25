using SeaWitches.DataAcces;
using SeaWitches.Models;

namespace SeaWitches.Services.HomeService
{
    public class HomeService : IHomeService
    {
        private IHomeDataAccess homeDataAccess;
        public HomeService() { 
            this.homeDataAccess = new HomeDataAccess();
        }
        public HomeModel GetHome()
        {
            return this.homeDataAccess.GetHome();
        }
    }
}
