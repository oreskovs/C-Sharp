using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieFetcherApp
{
    internal class MovieService
    {

        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "123123123123123123";


        public MovieService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Movie?> GetMovieAsync(string title)
        {
            string url = $"https://www.omdbapi.com/?apikey={_apiKey}&t={Uri.EscapeDataString(title)}";

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                using JsonDocument doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                if (root.GetProperty("Response").GetString() == "True")
                {
                    return new Movie
                    {

                        Title = root.GetProperty("Title").GetString(),
                        Year = root.GetProperty("Year").GetString(),
                        Director = root.GetProperty("Director").GetString(),
                        Genre = root.GetProperty("Genre").GetString(),
                        Plot = root.GetProperty("Plot").GetString()

                    };

                }
                else
                {
                    Console.WriteLine($"{title} is not found.");
                    return null;
                }

            }
            catch (Exception err)
            {
                Console.WriteLine($"Api call error {err.Message}");
                return null;
            }
        }
    }
}
