using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet("{Name}/{FName}")]
        //[Route("Home/Welcome")]
        //public IActionResult Welcome(string? Name, string? FName)
        //{
        //    TempData["Info"] = ("Your Name Is " + Name + " and Father Name Is " + FName);
        //    return View();
        //}

        public IActionResult Welcome()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Welcome(string Name, string FName)
        //{
        //    TempData["Info"] = ("Your Name Is " + Name + " and Father Name Is " + FName);
        //    return View();
        //}

        [HttpPost]
        public IActionResult MyData(string Name, string FName)
        {
            TempData["Info"] = ("Your Name Is " + Name + " and Father Name Is " + FName);
            return View("Welcome");
        }

    }
}
