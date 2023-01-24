using Microsoft.EntityFrameworkCore;
using TheTempleCompanyTasks.Console.Models;
using TheTempleTasks.Web.Services.Implementations;
using TheTempleTasks.Web.Services.Interfaces;

namespace TheTempleTasks.Web.Services
{
    public static class ServiceExtension
    {
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
            services.AddDbContext<JokeContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("JokeContext")));

        public static void ConfigureServices(this IServiceCollection services) =>
            services.AddScoped<IJokeService, JokeService>();
    }
}
