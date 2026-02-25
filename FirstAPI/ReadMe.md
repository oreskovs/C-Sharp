📚 FirstAPI - Book Management System
Welcome to FirstAPI, a clean and functional RESTful API built with ASP.NET Core. This project is part of my C-Sharp repository and demonstrates the implementation of full CRUD operations using modern .NET practices.

🛠 Technologies & Tools
Framework: ASP.NET Core Web API.

Database ORM: Entity Framework Core.

Database: SQL Server (Configured via Connection String).

Documentation & Testing: OpenAPI (Swagger) and Integrated .http testing.

🚀 Key Features
The API provides a complete interface for managing a library of books through the following endpoints:

GET /api/books: Retrieve a list of all books in the database.

GET /api/books/{id}: Fetch details of a specific book by its ID.

POST /api/books: Add a new book to the collection.

PUT /api/books/{id}: Update the details of an existing book.

DELETE /api/books/{id}: Remove a book from the system.

📊 Data Model
Each book entry consists of the following properties:

Id (Primary Key).

Title (String).

Author (String).

YearPublished (Integer).

The database is pre-seeded with classic titles such as "1984", "The Great Gatsby", and "Moby-Dick" for immediate testing.

💻 How to Run
Clone the repository:

Bash
git clone https://github.com/oreskovs/C-Sharp.git
Navigate to the project folder:

Bash
cd FirstAPI
Configure the Database: Update the Default Connection string in appsettings.json to point to your local SQL Server instance.

Run the Application:

Bash
dotnet run
Test the API: Use the provided FirstAPI.http file or the Swagger UI to interact with the endpoints.

Author: oreskovs