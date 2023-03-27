using Foodie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace Foodie.Controllers
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
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        [HttpPost]
        public async Task<ContentResult> Contacts(Contacts newContact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Api<Contacts> api = new Api<Contacts>();
                    var res = await api.Send(newContact, "Contacts");
                    return res.Success 
                        ? Content("<span class='alert alert-success'>Message Received Success</span>") 
                        : Content("<span class='alert alert-warning'>Something went wrong Success</span>");
                }
                return Content("<span class='alert alert-warning'>Invalid Data</span>");
            }
            catch (Exception e)
            {
                return Content("<span class='alert alert-danger'>something went wrong...</span>");
            }
        }
        public async Task<IActionResult> GetMenu()
        {
            Api<List<Category>> api = new Api<List<Category>>();
            var res = await api.Get("Categories");

            var data = res.Data;
            var category = new Category();
            List<Category> categories = new List<Category>();
            categories.Add(category);
            return View();
            //return categories;
        }

        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Testimonial()
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