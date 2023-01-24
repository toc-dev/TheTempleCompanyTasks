using Microsoft.AspNetCore.Mvc;
using TheTempleTasks.Web.Services.Interfaces;

namespace TheTempleTasks.Web.Controllers
{
    public class JokesController : Controller
    {
        private readonly IJokeService _jokeService;
        public JokesController(IJokeService jokeService)
        {
            _jokeService = jokeService;
        }
        public IActionResult GetJokes()
        {
            var jokes = _jokeService.GetAllJokes();
            return View(jokes);
        }
    }
}
