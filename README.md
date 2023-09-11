# Database First Approach With .NET Core

## Introduction

This repository demonstrates how to implement the Database First Approach in a .NET Core application. The Database First Approach allows you to generate the application's data model from an existing database schema, making it a suitable choice for projects that need to work with pre-existing databases.

## Features

- **Database Schema Import**: This project provides step-by-step instructions and code samples for importing an existing database schema into a .NET Core project.

- **Entity Framework Core**: We leverage Entity Framework Core, a popular Object-Relational Mapping (ORM) framework, to interact with the database. EF Core helps simplify database operations and provides a powerful set of tools for working with data.

## Getting Started

Follow these steps to get started with this project:

1. **Clone the Repository**: Use `git clone` to clone this repository to your local machine.

2. **Set Up Your Database Connection**: Edit the `appsettings.json` file to configure your database connection string.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "your_connection_string_here"
  },
  // ...
}
```

3. **Run Migrations**: Execute Entity Framework Core migrations to create the database schema and seed initial data (if needed). Use the following commands:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

4. **Build and Run**: Build and run your .NET Core application using the following commands:

```bash
dotnet build
dotnet run
```

## Usage

Describe how users can use your project. Include code examples and any specific instructions for interacting with your application.

## Contributing

If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.

2. Create a new branch for your feature or bug fix: `git checkout -b feature-name`.

3. Make your changes and commit them with descriptive messages.

4. Push your branch to your forked repository.

5. Create a pull request to merge your changes into the main repository.

## Contact

If you have any questions or need further assistance, please feel free to contact me at mernaabdallah89@gmail.com.

Happy coding!
