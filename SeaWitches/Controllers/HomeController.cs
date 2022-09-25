using Microsoft.AspNetCore.Mvc;
using SeaWitches.Models;
using SeaWitches.Services.HomeService;
using System.Diagnostics;

namespace SeaWitches.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHomeService homeService;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            homeService = new HomeService();
        }

        public IActionResult Index()
        {
            this.homeService.GetHome();
            return View();
        }

        public IActionResult Privacy()
        {
            this.homeService.GetHome();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}