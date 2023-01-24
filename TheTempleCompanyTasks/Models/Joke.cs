using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTempleCompanyTasks.Console.Models
{
    public class Joke
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Delivery { get; set; }
        public Guid FlagId { get; set; }
        public bool Safe { get; set; }
        public string Lang { get; set; }
        [ForeignKey("FlagId")]
        public virtual Flags Flags { get; set; }
    }

    public class Flags
    {
        public Guid Id { get; set; }
        public bool Nsfw { get; set; }
        public bool Religious { get; set; }
        public bool Political { get; set; }
        public bool Racist { get; set; }
        public bool Sexist { get; set; }
        public bool Explicit { get; set; }
        
    }
}
