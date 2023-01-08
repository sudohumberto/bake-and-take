using BakeAndTake.Repositories.Abstract;
using BakeAndTake.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BakeAndTake.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            PieListViewModel piesListViewModel = new(_pieRepository.AllPies, "Cheese cakes");
            return View(piesListViewModel);
        }
    }
}
