using Microsoft.AspNetCore.Mvc;

namespace TechShop.Controllers
{
    public class ContactController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
