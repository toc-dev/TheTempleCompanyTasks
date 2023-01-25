using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTempleCompanyTasks.Console.Models
{
    public class JokeContext : DbContext
    {
        string connectionString = @"Server=localhost;Database=JokesDB;Trusted_Connection=True; Encrypt=False; Integrated Security=true";
        public JokeContext(DbContextOptions<JokeContext> options) :base(options)
        {

        }
        public DbSet<Joke> Jokes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
