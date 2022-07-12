﻿using BakeAndTake.Models;
using Microsoft.AspNetCore.Mvc;

namespace BakeAndTake.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy(c => c.Name);
            return View(categories);
        }
    }
}
