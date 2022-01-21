# _Animal Shelter API_        

#### By **Christina Welch**

#### _An API that tracks Animals for an Animal Shelter_

## Technologies Used

* C#
* .net
* ASP.NET Core
* Razor
* CSS
* HTML
* Entity Framework
* SQL

## Description

_End of week friday project for epicodus school made to demonstrate skills in creating an API. This API tracks Animals for an Animal Shelter. It uses Swagger to better show the api calls in a UI and Versioning to allow for new versions as the API is updated._

## Setup/Installation Requirements

* Clone this repository to your desktop
* Open AnimalShelter.Solution/AnimalShelter in VScode or a code editor of your choice
* Create a new file and name it appsettings.json
* in the file add the following
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=[Your-Password-Here];"
  }
}
```
Note: make sure to replace [YOUR-PASSWORD-HERE] with your password for SQL.

* to change the port of the API go into Properties/launchSettings.json
```
...
      "applicationUrl": "https://localhost:5001;http://localhost:5000",
      // change your port here to whatever port you would like
...
```
* type dotnet ef database update into the terminal then type dotnet run

## Known Bugs

the Swagger UI doesnt work well with versioning and may not show versions for methods correctly

## License

MIT License

Copyright (c) [2022] [Christina Welch]