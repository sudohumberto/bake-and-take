using Microsoft.AspNetCore.Mvc;

namespace BakeAndTake.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
