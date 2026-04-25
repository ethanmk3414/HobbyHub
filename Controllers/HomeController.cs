using Microsoft.AspNetCore.Mvc;

namespace HobbyHub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutHobby()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult CleanPage()
        {
            return View();
        }
    }
}