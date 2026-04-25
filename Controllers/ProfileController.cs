using Microsoft.AspNetCore.Mvc;

namespace HobbyHub.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}