using DadJokesWeb.Data;
using DadJokesWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DadJokesWeb.Controllers
{
    public class JokeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public JokeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Joke> objJokeList = _db.Jokes;
            return View(objJokeList);
        }

        // GET
        public IActionResult Write()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Write(Joke obj)
        {
            if (ModelState.IsValid)
            {
                _db.Jokes.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Joke added successfully.";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                goto nf;
            }
            var jokeFromDb = _db.Jokes.Find(id);

            if (jokeFromDb == null)
            {
                goto nf;
            }

            return View(jokeFromDb);
        nf: return NotFound();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Joke obj)
        {
            if (ModelState.IsValid)
            {
                _db.Jokes.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Joke edited successfully.";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var jokeFromDb = _db.Jokes.Find(id);

            if (jokeFromDb == null)
            {
                return NotFound();
            }

            return View(jokeFromDb);
        }

        // POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Jokes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Jokes.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Joke deleted successfully.";
            return RedirectToAction("Index");
        }
    }
}
