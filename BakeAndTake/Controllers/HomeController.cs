using BakeAndTake.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BakeAndTake.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IPieRepository pieRepository)
        {
            _logger = logger;
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Controller: Home, Action: Index");
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogError("Error Captured by HomeController");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}