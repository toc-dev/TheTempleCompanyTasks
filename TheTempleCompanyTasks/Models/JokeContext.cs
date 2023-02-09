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
        public JokeContext(DbContextOptions<JokeContext> options) :base(options)
        {

        }
        public DbSet<Joke> Jokes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
