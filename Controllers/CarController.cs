using Microsoft.AspNetCore.Mvc;
using MyFriends.Models;

namespace MyFriends.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Model(string name, string year, string color)
        {
            CarModel s = new CarModel(name ?? "oopp", year ?? "oppp");
            
            return View(new ViewModel(s, color));
        }
    }
}
