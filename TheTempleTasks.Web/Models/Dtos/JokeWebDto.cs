namespace TheTempleTasks.Web.Models.Dtos
{
    public class JokeWebDto
    {
        public string Category { get; set; }
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Delivery { get; set; }
        public FlagsDto Flags { get; set; }
        public Guid Id { get; set; }
        public bool Safe { get; set; }
        public string Lang { get; set; }
    }

    public class FlagsDto
    {

        public bool Nsfw { get; set; }
        public bool Religious { get; set; }
        public bool Political { get; set; }
        public bool Racist { get; set; }
        public bool Sexist { get; set; }
        public bool Explicit { get; set; }
    }
}

