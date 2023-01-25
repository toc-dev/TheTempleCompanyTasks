using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Threading.Tasks;
using TheTempleCompanyTasks.Console.Dtos;

namespace TheTempleCompanyTasks
{
    public class JokeAPIClient
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _jokeUrl;
        public JokeAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _jokeUrl = "https://sv443.net/jokeapi/v2/joke/Any";
        }

        public JokeDto GetJoke()
        {
            JokeDto joke = new();
            var response = _httpClient.GetAsync(_jokeUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                joke = JsonConvert.DeserializeObject<JokeDto>(response.Content.ReadAsStringAsync().Result);
            }
            
            return joke;
        }
    }
}
