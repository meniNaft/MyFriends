using Microsoft.AspNetCore.Mvc;
using MyFriends.Models;

namespace MyFriends.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Model(string name, string year)
        {
            CarModel s = new CarModel(name ?? "oopp", year ?? "oppp");
            return View(s);
        }
    }
}
