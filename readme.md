# wwu-feedback



## Tools

- Dotnet 8
- ASP.NET Core MVC Web App
- VS Code
- [Excalidraw](https://excalidraw.com/)

## Libraries

- [Entity Framework Core 8](https://learn.microsoft.com/en-us/ef/core/)
- [XUnit]()

## Project startup commands

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