using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPDotNetDemo.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string > options = new List<string>() {"select OPtion","Yes","No"};
            ViewData["options"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form)
        {
            ViewBag.UserName = form["username"];
            ViewBag.Email = form["email"];
            ViewBag.Gender = form["gender"];
            ViewBag.Option = form["options"];
            return View("Details");

        }
    }
}
