using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {

            User user = new User();
            user.Name = "Nimohe";
            user.Email = "nimohe@hotmail.com";

            return View(user);
        }
    }
}
