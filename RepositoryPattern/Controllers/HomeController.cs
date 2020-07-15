using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryPattern.EntityModel;
using RepositoryPattern.Models;
using RepositoryPattern.Pattern.Interfaces.IUnitOfWorks;
using RepositoryPattern.Pattern.Repositories.UnitOfWork;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _work;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _work = unitOfWork;
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult SaveSubCategory()
        {
            SubCategory subCategory = new SubCategory()
            {
                CategoryId = 1,
                Name = "Samsung",
            };
            _work.SubCategory.Save(subCategory);
            int some = _work.Save();
            return Json(true);
        }

        public IActionResult SaveCategory()
        {
            Category category = new Category()
            {
                Name = "Mobile",
            };
            _work.Category.Save(category);
            int some = _work.Save();
            return Json(true);
        }

        public IActionResult CategoryList()
        {
            var catrgoryList = _work.Category.GetAll().ToList();
            return Json(catrgoryList);
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
