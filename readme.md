# wwu-feedback



## Tools

- Dotnet 8
- ASP.NET Core MVC Web App
- VS Code
    - `mssql` extension - Provides Database support
- Docker (only needed for local/offline development)
- [Excalidraw](https://excalidraw.com/)

## Libraries

- [Entity Framework Core 8](https://learn.microsoft.com/en-us/ef/core/)
- [XUnit]()

## Project startup commands

### Initial Repo creation
To create the shell of the project start with the following commands:
```
mkdir wwu-feedback
cd wwu-feedback
git init
dotnet new gitignore
code .
```

Update Readme

### Setting up project structure and seeding projects
```
mkdir src
mkdir test
mkdir docs
dotnet new sln
cd src
mkdir gabema.wwufeedback.webapp
mkdir gabema.wwufeedback.migrations
cd gabema.wwufeedback.webapp
dotnet new webapp
cd ..\gabema.wwufeedback.migrations
dotnet new classlib
cd ..\..\test
mkdir gabema.wwufeedback.unittests
cd gabema.wwufeedback.unittests
dotnet new xunit
cd ..\..
dotnet sln add src\gabema.wwufeedback.migrations src\gabema.wwufeedback.webapp test\gabema.wwufeedback.unittests
cd src\gabema.wwufeedback.webapp
dotnet add reference ..\gabema.wwufeedback.migrations
cd ..\..\test\gabema.wwufeedback.unittests
dotnet add reference ..\..\src\gabema.wwufeedback.migrations
dotnet add reference ..\..\src\gabema.wwufeedback.webapp
cd ..\..
dotnet build
dotnet test
```

### Create a Azure SQL local database project/instance

Create a local database instance that will behave like our Azure SQL Database that we'll eventually deploy to.
1. Make sure Docker is installed and up to date.
1. Make sure VS Code mssql extension is installed.
1. Create a database project.
1. Publish the database project to a Azure SQL emulator.
1. Connect to the database via SQL Server tab.

### Initialize EF Core Database project

```
cd .\src\gabema.wwufeedback.migrations\
dotnet add package Microsoft.EntityFrameworkCore -s https://api.nuget.org/v3/index.json
dotnet add package Microsoft.EntityFrameworkCore.Design -s https://api.nuget.org/v3/index.json
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -s https://api.nuget.org/v3/index.json
```

## Helpful resources

[Local Azure SQL DB Development](https://learn.microsoft.com/en-us/azure/azure-sql/database/local-dev-experience-quickstart?view=azuresql)
