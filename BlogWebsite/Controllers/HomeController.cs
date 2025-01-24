using BlogWebsite.Data;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Students student)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Students.Add(student);
                db.SaveChanges();
            }

            TempData["Message"] = "Data Saved Successfully.";

            return View();
        }

        public IActionResult Welcome()
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

        //[HttpPost]
        //public IActionResult Welcome(string Name, string FName)
        //{
        //    TempData["Info"] = ("Your Name Is " + Name + " and Father Name Is " + FName);
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult MyData(string Name, string FName)
        //{
        //    TempData["Info"] = ("Your Name Is " + Name + " and Father Name Is " + FName);
        //    return View("Welcome");
        //}

        //[HttpPost]
        //public IActionResult MyData(Student student)
        //{
        //    TempData["Info"] = ("Your Name Is " + student.Name + " and Father Name Is " + student.FName + " and your Mobile Number Is " + student.Mobile);
        //    return View("Welcome");
        //}
    }
}
