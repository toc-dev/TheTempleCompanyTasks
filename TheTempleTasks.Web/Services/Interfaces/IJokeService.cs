using TheTempleTasks.Web.Models.Dtos;

namespace TheTempleTasks.Web.Services.Interfaces
{
    public interface IJokeService
    {
        List<JokeWebDto> GetAllJokes();
    }
}
