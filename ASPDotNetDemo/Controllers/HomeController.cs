using ASPDotNetDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPDotNetDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> colors = new List<string>()
            {
                "Red","Blue","Green","Orange","Pink","Black"
            };
            ViewData["Colors"] = colors;
            //ViewData["message"] = "Hello from controller";
            //using view bag
            ViewBag.Colors = colors;
            TempData["message"] = "hello from controller";
            TempData.Keep("message");//keep method will keep the data for multiple req.
            return View();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}