using Microsoft.AspNetCore.Mvc;
using MyFriends.DAL;
using MyFriends.Models;
using System.Diagnostics;

namespace MyFriends.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataContext dbcontext;
        public HomeController(ILogger<HomeController> logger, DataContext dbContext)
        {
            _logger = logger;
            this.dbcontext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFriends()
        {
            List<Friend> friends = new List<Friend>
            {
                new Friend
                {
                    FirstName = "meni",
                    LastName = "naftalin",
                    EmailAddress = "mnaft404@gmail.com",
                    Phone = "053-7731203"
                },
                 new Friend
                {
                    FirstName = "chani",
                    LastName = "naftalin",
                    EmailAddress = "sss@gmail.com",
                    Phone = "053-7732837"
                }
            };
            dbcontext.Friends.AddRange(friends);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
