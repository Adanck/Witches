using SeaWitches.Models;

namespace SeaWitches.Services.HomeService
{
    public interface IHomeService
    {
        public HomeModel GetHome();
        public PageModel GetAllPage();
    }
}
