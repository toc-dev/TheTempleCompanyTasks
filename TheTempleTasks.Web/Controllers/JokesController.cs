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
            try
            {
                var jokes = _jokeService.GetAllJokes();
                if (jokes == null)
                {
                    ViewBag.Error = "No Jokes Found";
                    return View();
                }
                return View(jokes);
            }
            catch (Exception ex)
            {
               ViewBag.Error = "An error occurred while processing your request: " + ex.Message;
                return View();
            }
        }
    }
}
