// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using MovieFetcherApp;

namespace MyApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            MovieService service = new MovieService();

            Console.WriteLine("Enter movie title");
            string enteredTitle = Console.ReadLine();

            Movie? movie = await service.GetMovieAsync(enteredTitle);

            if (movie != null)
            {
                Console.WriteLine("===== Movie informations =====");
                Console.WriteLine($"Title: {movie.Title}");
                Console.WriteLine($"Year: {movie.Year}");
                Console.WriteLine($"Genre: {movie.Genre}");
                Console.WriteLine($"Director: {movie.Director}");
                Console.WriteLine($"Plot: {movie.Plot}");
            }
            else
            {
                Console.WriteLine($"We don`t have informations about movie: {enteredTitle}");
            }

        }

    }
}