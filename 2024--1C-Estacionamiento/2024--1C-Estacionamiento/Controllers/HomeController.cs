using _2024__1C_Estacionamiento.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2024__1C_Estacionamiento.Controllers
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
            return View();
        }

        public IActionResult Index1(int ?num)
        {
            
            return View(num);
        }

        public IActionResult Index2()
        {
            List <String> ciudades = new List<String> { "Buenos Aires", "Roma","Madrid"};
            return View(ciudades);
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
