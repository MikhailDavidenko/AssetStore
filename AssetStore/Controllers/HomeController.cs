using AssetStore.Data;
using AssetStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssetStore.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Unity(int page = 1)
        {
            int pageSize = 12;
            var assets = MockData.GetMockAssets()
                .OrderBy(a => a.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var totalItems = MockData.GetMockAssets().Count;
            var viewModel = new AssetsViewModel
            {
                Assets = assets,
                CurrentPage = page,
                TotalPages = (int)System.Math.Ceiling((double)totalItems / pageSize)
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}