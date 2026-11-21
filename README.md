# Student Course Registration System (ASP.NET Core MVC)

## Requirements
- .NET SDK 8.0 (https://dotnet.microsoft.com/download)
  - Have .NET 9? Change `<TargetFramework>` in `StudentRegistration.csproj` to `net9.0`
    and `net8.0` to `net9.0` in `.vscode/launch.json`.
- VS Code with the "C# Dev Kit" or "C#" extension

## Run
1. Unzip and open the `StudentRegistration` folder in VS Code (File > Open Folder).
2. Open the terminal (Ctrl + `) and run:

       dotnet run

3. Open http://localhost:5000 in your browser.
   (Or press F5 in VS Code.)

## Pages
- Home:               /Home/Index
- Register (form):    /Student/Create
- Student list:       /Student/Index
- Student details:    /Student/Details/1

Data is kept in a static in-memory list, so it resets when the app restarts.
