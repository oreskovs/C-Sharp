# MovieInfoFetcher

A simple C# console application that fetches and displays information about movies using the [OMDb API](https://www.omdbapi.com/).

## 🎯 Features

- Fetch movie data (title, year, genre, director, plot) from the OMDb API
- Asynchronous HTTP requests using `HttpClient`
- JSON parsing with `System.Text.Json`
- Clean and structured code following object-oriented principles

## 🚀 Getting Started

### Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download) or higher
- A valid API key from [OMDb API](https://www.omdbapi.com/apikey.aspx)

### Setup

1. Clone the repository:

```bash
git clone https://github.com/oreskovs/C-Sharp.git/movie-info-fetcher.git
cd movie-info-fetcher
```

2. Open the project in your favorite IDE (e.g., Visual Studio or VS Code)

3. Replace the placeholder API key in `MovieService.cs`:

```csharp
private readonly string _apiKey = "your_api_key_here";
```

4. Run the application:

```bash
dotnet run
```

## 🖼️ Example Output

```
Enter movie title
Inception
===== Movie informations =====
Title: Inception
Year: 2010
Genre: Action, Adventure, Sci-Fi
Director: Christopher Nolan
Plot: A thief who steals corporate secrets through the use of dream-sharing technology...
```

## 🧠 What You’ll Learn

- Working with third-party APIs in C#
- Handling asynchronous operations
- Parsing JSON safely
- Organizing code with services and models

## 📁 Project Structure

```
├── Program.cs
├── Movie.cs
├── MovieService.cs
└── README.md
```

## 📜 License

This project is licensed for learning purposes.

---

*Built with ❤️ by [Stojance Oreskov](https://github.com/oreskovs)*