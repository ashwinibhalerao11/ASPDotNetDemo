using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
