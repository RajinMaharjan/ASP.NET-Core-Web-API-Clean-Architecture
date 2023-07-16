# ASP.NET-Core-Web-API-Clean-Architecture
## Setup solution with Clean Architecture
1. Open Microsoft Visual Studio and create new blank/empty project OR (Create folder name for solution and open cmd. Input command:
2.     dotnet new sln
3.	Create two folders:
    - src
    - tets (You must include this if you are writing and testing code)
 4.	Inside src folder:
    - Create ASP.NET Core Web API project with name Api.
    - Create Console App project with name Application.
    - Create Console App project with name Domain.
    - Create Console App project with name Infrastructure.
5. Inside tests folder:
    - Create NUnit Test Project with name Application.IntegrationTests.
    - Create NUnit Test Project with name Application.UnitTests.
    - Create NUnit Test Project with name Domain.UnitTests.
6. Inside Api Project add folders named:
    - Common
    - Controllers
    - (AppName)App, for example: ClientApp. {Note:- This is done when the frontend is integrated with backend in a single project.}
7. Inside Application Project add folder named:
    - Common
8. Inside Domain Project add folders named:
    - Common
    - Entities
    - Enums
9. Inside Infrastructure Project add folders named:
    - Common
    - Configurations
    - Helpers
    - Localization
    - Persistence
    - Services
10. Add Project references for all project as:
    - For Api {Application, Infrastructure}
    - For Application {Domain}
    - For Domain {}
    - For Infrastructure {Application, Domain}
11. To add project references:
    - Go to project and right click on it
    - Click on Add.
    - Click on project reference.
  {
  Note:
        - While creating project don’t forget to add “\src” in location
        - In properties of Application, Domain and Infrastructure, change output type to Class Library
  }


## Adding migration and updating database using console 
### Adding Migration
    dotnet ef migrations add "migration message" --project src/Infrastructure --startup-project src/Api -o Persistence/Migrations 
### Updating database
    dotnet ef database update  --project src/Infrastructure --startup-project src/Api 
