using Microsoft.AspNetCore.Mvc;
using TechShop.ViewModels;
using TechShop.Repositories;

namespace TechShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository ProductRepository)
        {
            _productRepository = ProductRepository;
        }

        public ViewResult Index()
        {
            var productsOfTheWeek = _productRepository.ProductsOfTheWeek;

            var homeViewModel = new HomeViewModel(productsOfTheWeek);

            return View(homeViewModel);
        }
    }
}
