# JsonPlaceholder User Analyzer

This C# console application fetches and processes user, post, and comment data from the [JSONPlaceholder API](https://jsonplaceholder.typicode.com/). It demonstrates object-oriented design, LINQ data processing, and JSON serialization in a real-world context.

## 📌 Features

- Fetches users, posts, and comments from the API.
- Associates each user with their posts and each post with its comments.
- Filters users who have at least one post with more than 3 comments.
- Displays detailed information about these "popular" users and their posts.
- Saves the result to a `popular_users.json` file.

## 📂 Project Structure

- `User.cs` — User class with nested `Address`, `Geo`, and `Company` objects.
- `Post.cs` — Represents a post with a list of comments.
- `Comment.cs` — Represents a comment.
- `Program.cs` — Contains the async logic for fetching, processing, filtering, and saving data.

## 🛠 Technologies Used

- C# (.NET)
- `HttpClient` for API communication
- `System.Text.Json` for JSON serialization/deserialization
- LINQ for filtering and data transformation
- Asynchronous programming (async/await)

## ▶ How to Run

1. Clone the repository
2. Open the project in Visual Studio or VS Code
3. Build and run the app (`dotnet run`)
4. Check the output in the console and `popular_users.json`

## 📁 Example Output

Console output:


Saved file: `popular_users.json`

## ✅ Learning Goals

- Practice with real JSON API data
- Strengthen OOP modeling (composition)
- Work with collections using LINQ
- Handle async API calls and error management

## © License

This project is for educational purposes only.
