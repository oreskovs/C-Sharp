using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using OOP___LINQ_Practice;

namespace MyApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();

            string usersUrl = "https://jsonplaceholder.typicode.com/users";
            string postsUrl = "https://jsonplaceholder.typicode.com/posts";
            string comsUrl = "https://jsonplaceholder.typicode.com/comments";

            try
            {
                var uResponse = await client.GetAsync(usersUrl);
                string uJson = await uResponse.Content.ReadAsStringAsync();
                List<User> users = JsonSerializer.Deserialize<List<User>>(uJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var pResponse = await client.GetAsync(postsUrl);
                string pJson = await pResponse.Content.ReadAsStringAsync();
                List<Post> posts = JsonSerializer.Deserialize<List<Post>>(pJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var cResponse = await client.GetAsync(comsUrl);
                string cJson = await cResponse.Content.ReadAsStringAsync();
                List<Comment> comments = JsonSerializer.Deserialize<List<Comment>>(cJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });


                foreach (var user in users)
                {
                    user.Posts = posts.Where(p => p.UserId == user.Id).ToList();
                }

                foreach(var post in posts)
                {
                    post.Comments = comments.Where(c => c.PostId == post.Id).ToList();
                }

                var popularUsers = users.Where(u => u.Posts.Any(p => p.Comments.Count > 3));

                foreach(var user in popularUsers)
                {
                    Console.WriteLine($"Name: {user.Name} | Email: {user.Email}");

                    foreach(var post in user.Posts)
                    {
                        var comCount = post.Comments.Count();

                        Console.WriteLine($"ID: {post.Id} | Title: {post.Title} | Number of comments: {comCount}");
                    }

                    Console.WriteLine();
                }

                using FileStream data = File.Create("popular_users.json");
                await JsonSerializer.SerializeAsync(data, popularUsers, new JsonSerializerOptions
                {
                    WriteIndented = true
                });


            }catch(Exception ex)
            {
                Console.WriteLine("Failed to fetch API " + ex.Message);
            }
        }

    }
}
