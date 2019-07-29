# Sample ASP.NET Core MVC app

* Install [dotnet core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/Download)

## Copy the template project to your own repo
Fork the repo if you have your own GitHub account!

Or:
* Clone [this repo](https://github.com/scottmcelveen/aspnetcore-mvc-movies.git)
* `git remote set-url origin <YOUR-REPO-URL>`
* `git push origin master`

## Run the app
* `cd <checkout dir>`
* `dotnet build`
* `dotnet run -p aspnetcore-mvc-movies_default.csproj`
* visit `http://localhost:5000`

## Run the app with Docker - if you already have it working!
* `docker-compose up`
* visit `http://localhost:5000`
