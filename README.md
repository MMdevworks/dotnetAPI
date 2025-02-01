## About The Project

This is a simple .NET Web API project demonstrating the use of HTTP methods (GET, POST, PUT, DELETE) to interact with API endpoints. Swagger is integrated for interactive API documentation and testing. 

<b>Project Goal:</b> Knowledge and Growth


### Built With
 [![Csharp][csharp-badge]][csharp-url]
 [![Dotnet][dotnet-badge]][Dotnet-url]


<!-- GETTING STARTED -->
## Getting Started

### Installation
1. Clone the repo
   ```sh
   > git clone https://github.com/MMdevworks/dotnetAPI.git
   > cd dotnetApi
   ```
3. Open the project
   ```
   Visual Studio 2022 or preferred IDE
   ```
4. Restore NuGet package dependancies
   ```
   In Visual Studio go to: 
		Tools > NuGet Package Manager > Manage NuGet Packages for Solution > Restore dependencies

   Packages Used:
	- Microsoft.EntityFrameworkCore  
	  Entity Framework Core is a modern object-database mapper for .NET.
	- Microsoft.EntityFrameworkCore.InMemory
	  In-memory database provider for Entity Framework Core (to be used for testing purposes).
	- Swashbuckle.AspNetCore
	  Swagger tools for documenting APIs built on ASP.NET Core
   ```
5. Run the application
   ```
   Set the startup project if necessary.
   Run the program via play button or press f5
   ```
6. Access Swagger UI
   ```
   https://localhost:<port>/swagger
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>

[dotnet-badge]: https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
[Dotnet-url]: https://dotnet.microsoft.com/
[csharp-badge]: https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white
[csharp-url]: https://learn.microsoft.com/en-us/dotnet/csharp/