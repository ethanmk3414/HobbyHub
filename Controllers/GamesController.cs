using Microsoft.AspNetCore.Mvc;
using HobbyHub.Models;
using System.Linq;

namespace HobbyHub.Controllers
{
    public class GamesController : Controller
    {
        private readonly HobbyContext _context;

        public GamesController(HobbyContext context)
        {
            _context = context;
        }

        // READ
        public IActionResult Index()
        {
            return View();
        }

        // CREATE (GET)
        public IActionResult Create()
        {
            return View();
        }

        // CREATE (POST)
        [HttpPost]
        public IActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Games.Add(game);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(game);
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var game = _context.Games.Find(id);

            if (game != null)
            {
                _context.Games.Remove(game);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}