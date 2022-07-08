using BakeAndTake.Models;
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

        public ViewResult List()
        {
            // Use ViewBag
            //ViewBag.CurrentCategory = "Cheese Cakes";

            // Or a ViewModel
            PiesListViewModel piesListViewModel = new() 
            {
                Pies = _pieRepository.AllPies,
                CurrentCategory = "Cheese Cakes"
            };

            return View(piesListViewModel);
        }
    }
}
