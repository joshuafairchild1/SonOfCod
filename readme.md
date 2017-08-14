# Son of Cod Seafood
### Joshua Fairchild, August 11th, 2017

This is an application that demonstrates user authentication and unit testing using the .NET framework. A user is able to put some information into a form to sign-up for an imaginary newsletter, and "Admin" users are able to login/create an account to view the users that are subscribed to the newsletter.

<!-- ## Screenshots
#### Landing/Marketing Page
![](src/SonOfCod/wwwroot/images/scrn1.png) -->

<!-- #### Newsletter Signup
![](src/SonOfCod/wwwroot/images/scrn2.png) -->

<!-- #### Subscriber List
![](src/SonOfCod/wwwroot/images/scrn3.png) -->

## Prerequisites

You will need the following software properly installed on your computer.

* [Visual Studio 2015](https://www.visualstudio.com/vs/older-downloads/)
* [Microsoft SQL Server](https://www.microsoft.com/en-in/sql-server/sql-server-downloads)

## Installation/Database Setup

* Clone this repository.

  `$ git clone https://github.com/joshuafairchild1/sonofcod`

* Open MS SQL Server and establish a local connection.

* In Visual Studio, open and build the project.

* Run the following commands in PowerShell to generate the database:

  `$ cd .\src\SonOfCod\`

  `$ dotnet ef database update 20170811202132_AddNewsletterModel`

* You can now view the application by pressing Ctrl + F5 in Visual Studio, you will be navigated to the application in your web browser.


## Built With

* C#
* ASP.NET Core MVC
* Microsoft SQL Server
* Entity, Identity, and xUnit (C# frameworks)
* CSS

## License

This project is licensed under the MIT License

Copyright (c) Joshua Fairchild, 2017
