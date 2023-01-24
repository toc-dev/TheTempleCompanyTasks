
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TheTempleCompanyTasks.Console.Models;

namespace TheTempleCompanyTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            JokeAPIClient apiClient = new JokeAPIClient(httpClient);
            var jokeDto = apiClient.GetJoke();

            System.Console.WriteLine();

            System.Console.WriteLine("Type " + jokeDto.Type);
            System.Console.WriteLine("Setup " + jokeDto.Setup);
            System.Console.WriteLine("Delivery " + jokeDto.Delivery);
            System.Console.WriteLine("Safe " + jokeDto.Safe);
            System.Console.WriteLine("Press any key to save joke");

            System.Console.ReadLine();


            Joke jokeDb = new Joke()
            {
                Category = jokeDto.Category,
                Type = jokeDto.Type,
                Setup = jokeDto.Setup,
                Delivery = jokeDto.Delivery,

                Flags = new Flags()
                {
                    Nsfw = jokeDto.Flags.Nsfw,
                    Religious = jokeDto.Flags.Religious,
                    Political = jokeDto.Flags.Political,
                    Racist = jokeDto.Flags.Racist,
                    Explicit= jokeDto.Flags.Explicit,
                    Sexist = jokeDto.Flags.Sexist,

                },
                Safe = jokeDto.Safe,
                Lang = jokeDto.Lang,

            };

            var connectionString = ConfigurationManager.ConnectionStrings["JokesDB"].ConnectionString;
                //@"Server=localhost;Database=JokesDB;Trusted_Connection=True; Encrypt=False; Integrated Security=true";
            var optionsBuilder = new DbContextOptionsBuilder<JokeContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var options = optionsBuilder.Options;
            using (var context = new JokeContext(options))
            {
                context.Jokes.Add(jokeDb);
                context.SaveChanges();
                System.Console.WriteLine("Joke saved to the database");
            }
            System.Console.ReadLine();
        }
    }
}