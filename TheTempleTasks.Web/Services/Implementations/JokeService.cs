using Microsoft.EntityFrameworkCore;
using TheTempleCompanyTasks.Console.Models;
using TheTempleTasks.Web.Models.Dtos;
using TheTempleTasks.Web.Services.Interfaces;

namespace TheTempleTasks.Web.Services.Implementations
{
    public class JokeService : IJokeService
    {
        protected JokeContext _jokeContext;
        public JokeService(JokeContext jokeContext)
        {
            _jokeContext = jokeContext;
        }

        public List<JokeWebDto> GetAllJokes()
        {
            var jokes = _jokeContext.Jokes.Include(x=>x.Flags).ToList();
            var allJokes = jokes.Select(j => new JokeWebDto
            {
                Category = j.Category,
                Type = j.Type,
                Setup = j.Setup,
                Delivery = j.Delivery,
                Id = j.Id,
                Safe = j.Safe,
                Lang = j.Lang,
                Flags = new FlagsDto
                {
                    if(j.Flags != null)
                    Nsfw = j.Flags.Nsfw,
                    Religious = j.Flags.Religious,
                    Political = j.Flags.Political,
                    Racist = j.Flags.Racist,
                    Sexist = j.Flags.Sexist,
                    Explicit = j.Flags.Explicit
                }
            }).ToList();

            return allJokes;
        }
    }
}
