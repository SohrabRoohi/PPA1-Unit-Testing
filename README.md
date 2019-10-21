# PPA2 CI/CD with Test Doubles
# Setup

This application has been developed for Windows 10, it may also work on Linux but I have not tested it.

### Requirements
1. Latest version of Visual Studio 2019
2. [.NET Core 3.0 SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-3.0.100-windows-x64-installer)

### Docker
Ensure that your docker VM has atleast 3GB of memory allocated to be able to run the Microsoft SQL Server instance (Otherwise it will crash).

Run the sohrabsql image with this exact command:
```docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -p 1433:1433 -d sohrabroohi/sohrabsql:sohrabsql```

It is important that the database runs on port 1433 as that it was Microsoft SQL Server's default port is.

### Visual Studio
Ensure that you have the latest version of Visual Studio and installed .NET Core 3.0 SDK or this will not work.

1. Clone the latest version of this project and open the PPA1.sln.
2. In the Solution Explorer right click on the "Solution 'PPA1'" and click properties.
3. Check Multiple startup projects and for "PPA1" and "WebAPI" switch their Action to "Start" and click Ok.
4. **You must change the Database connection string in PPA1/Config.cs to match your docker-machine ip, the default machine ip for Docker Toolkit is 192.169.99.100, find your machine ip by running the command: `docker-machine ip`**.
5. Run the project by hitting the green start button at the top of the screen, both the console application and REST API should run.

### Web API
**GET**  
1. http://localhost:5000/Distance  
2. http://localhost:5000/BMI  

**Post**  
1. http://localhost:5000/Distance  
Body Example (JSON):
```
{
	"x1": -1,
	"y1": 6,  
	"x2": 170,  
	"x2": 170 
}
```
2. http://localhost:5000/BMI  
Body Example (JSON):
```
{
	"heightInFeet": 5,
	"heightInInches": 11,  
	"weight": 123
}
```
# Continuous Integration
[Azure Devops](https://dev.azure.com/sohrabroohi/PPA2/_build?definitionId=2)


# Screencasts
You can find the screencasts in the in the [Screencasts](https://github.com/SohrabRoohi/PPA1-Unit-Testing/tree/master/Screencasts/PPA2) folder (RootFolder/Screencasts/PPA2).
