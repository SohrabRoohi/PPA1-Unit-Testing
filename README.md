<<<<<<< HEAD
# PPA2 CI/CD with Test Doubles
=======
# PPA1-Unit-Testing
# Organization
The assignment was completed in C# .NET Core for which Microsoft Visual Studio 2019 was utilized to create the functions and MSUnit tests. 
### Project Structure
```
Solution  
│   README.md
└───PPA1
│   │   Program.cs
│   │   Functions.cs
└───PPA1Tests
    │   UnitTest1.cs
```
Based on the project structure I have created two seperate projects in Visual Studio, one to hold the CLI and functions and another to hold the tests.

[Program.cs](https://github.com/SohrabRoohi/PPA1-Unit-Testing/blob/master/PPA1/Program.cs) - Contains all the CLI code, input/output, and calls the functions desired by the specifications. (This code was not expected to have code coverage as specified)

[Functions.cs](https://github.com/SohrabRoohi/PPA1-Unit-Testing/blob/master/PPA1/Functions.cs) - Contains the four functions that were described in the assignment specifications. BMI, Retire, Distance, and Split.

[UnitTest1.cs](https://github.com/SohrabRoohi/PPA1-Unit-Testing/blob/master/PPA1Tests/UnitTest1.cs) - Contains the four unit testing functions that test the functions implemented in Functions.cs. Uses Assert statements to analyze output of the functions.

### Naming
Following C# conventions classes and functions are named in PascalCase. The unit tests are are also named in PascalCase and have a word in them to identify which function it is testing (e.g. BMITest() or RetireTest()).

### Test Functionality

The tests will use multiple assert statements to test the different cases of the specified functions. Invalid input (such as negative numbers) will be given and appropriate output should also match that.

### Functions
[public string BMI(double heightFeet, double heightInches, double weight)](https://github.com/SohrabRoohi/PPA1-Unit-Testing/blob/6c77b9333054a50f35092b9d86f9d2a4431bc591/PPA1/Functions.cs#L9)  
Takes parameters indicated and will return a string in the format "BMIValue weightType" where BMIValue is a double rounded to two decimal places. If parameters given are invalid it will instead return "Impossible".

[public string Retire(int age, double salary, double percentage, double goal)](https://github.com/SohrabRoohi/PPA1-Unit-Testing/blob/6c77b9333054a50f35092b9d86f9d2a4431bc591/PPA1/Functions.cs#L38)  
Takes paramters indicated and returns a string based on age, if age is < 100 returns "age years old". If age >= 100 returns "age years old, you died!" If parameters given are invalid it will instead return "Impossible".

[public double Distance(double x1, double y1, double x2, double y2)](https://github.com/SohrabRoohi/PPA1-Unit-Testing/blob/6c77b9333054a50f35092b9d86f9d2a4431bc591/PPA1/Functions.cs#L57)  
Takes parameters indicated and returns the distance between (x1, 1) and (x2,y2) as a double rounded the two decimal places.

[public List<double> Split(double amount, int number)](https://github.com/SohrabRoohi/PPA1-Unit-Testing/blob/6c77b9333054a50f35092b9d86f9d2a4431bc591/PPA1/Functions.cs#L62)  
Takes paramters indicated and creates a List of double **L** of size **number** (parameter) which where the L[i] indicates how much the **i**th person in the group should pay. If the amount cannot be split equally the remainder **R** is equally distributed between the first **R** people. If parameters given are invalid it will return an empty List.


>>>>>>> d64fa71a04e68f34f8e417d7c71963941734956f
# Setup

This application has been developed for Windows 10, it may also work on Linux but I have not tested it.

<<<<<<< HEAD
###Requirements
1. Latest version of Visual Studio 2019
2. [.NET Core 3.0 SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-3.0.100-windows-x64-installer)

###Docker
Ensure that your docker VM has atleast 3GB of memory allocated to be able to run the Microsoft SQL Server instance (Otherwise it will crash).

Run the sohrabsql image with this exact command:
```docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -p 1433:1433 -d sohrabroohi/sohrabsql:sohrabsql```

It is important that the database runs on port 1433 as that it was Microsoft SQL Server's default port is.

###Visual Studio
Ensure that you have the latest version of Visual Studio and installed .NET Core 3.0 SDK or this will not work.

1. Clone the latest version of this project and open the PPA1.sln.
2. In the Solution Explorer right click on the "Solution 'PPA1'" and click properties.
3. Check Multiple startup projects and for "PPA1" and "WebAPI" switch their Action to "Start" and click Ok.
4. **You must change the Database connection string in PPA1/Config.cs to match your docker-machine ip, the default machine ip for Docker Toolkit is 192.169.99.100, find your machine ip by running the command: `docker-machine ip`**.
5. Run the project by hitting the green start button at the top of the screen, both the console application and REST API should run.

###Web API
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
#Continuous Integration
[Azure Devops](https://dev.azure.com/sohrabroohi/PPA2/_build?definitionId=2)


# Screencasts
You can find the screencasts in the in the [Screencasts](https://github.com/SohrabRoohi/PPA1-Unit-Testing/tree/master/Screencasts/PPA2) folder (RootFolder/Screencasts/PPA2).
=======

### Windows Executable

To run the application without the tests I have created an stand-alonre Windows executable. A shortcut to the executable is in the root folder of the repo named "PPA1.exe (Run this to test)". Double click this to run the application in a Windows command prompt.

###  Visual Studio

To setup and run the tests/applications you will need Microsoft Visual Studio.

[Visual Studio 2019 Download](https://visualstudio.microsoft.com/downloads/) (choose Community Edition)

A Visual Studio installer should pop up and please add the following additions to the installation:  
**.NET Desktop Development**  
**.NET Core cross-platform development**  

Then click the install button at the bottom right.

Once the installation is done, you may **clone** the repo on Github to your computer.

In the root folder you will see the Solution file **PPA1.sln**, double click that to open the project. (If prompted, use Visual Studio to open the file)

The project should now be open in Visual Studio and you should be able to see the project structure in the Solution Explorer on the right side of your screen (View->Solution Explorer).

You should be able to see **Functions.cs** and **Program.cs** in the PPA1 folder and **UnitTest1.cs** in the PPA1Tests folder.

To run the application hit the Green Play button at the top that has PPA1 next to it.

To run the tests go to Test->Windows->Test Explorer and once the Test Explorer pops up hit the Green Play button that in that window. This should run all the tests and show the results.

### Code Coverage
To see the Code Coverage for the project I have used dotCover by JetBrains, you can download it for free with a @ufl.edu email address.

[dotCover Download](https://www.jetbrains.com/dotcover/)

In the installer, all you need is dotCover and make sure Visual Studio 2019 integration is enabled.

Once installation is complete, restart Visual Studio.

With the project open, go to Extensions->ReSharper->Unit Tests->Unit Tests. In the window that opens click the shield icon which says "Cover Unit Tests", another window should pop with the results for the code coverage and each if you go into each class file you can see which lines are covered. Please note Program.cs is not expected to be covered because it is just the code for the CLI input/output.

# Tests Passing

![alt text](https://raw.githubusercontent.com/SohrabRoohi/PPA1-Unit-Testing/master/Screenshots/PPA1TestExplorer.png "Test Explorer")  
The green check mark indicates the tests passed in the duration given.

# Code Coverage
![alt text](https://raw.githubusercontent.com/SohrabRoohi/PPA1-Unit-Testing/master/Screenshots/PPA1Coverage.png "Coverage Explorer")  
The methods in Functions.cs have 100% code coverage, Program.cs does not count because that contains all of the CLI code.

# Retrospective
Author: Sohrab Roohi

My experience with unit testing and test driven development was very insightful. I gained some more experience writing unit tests and it was my first time going with the "write the test first" approach. I think unit testing is a very important aspect to software development as it helps catch bugs from future changes. The idea of TDD is also very important because it makes you think of edge cases and expected values before the fact which helps you design your functions. It would definitely be useful for a real project especially when it is important that there be no mistakes in the code. However, on the other hand the only drawback I had when using TDD was that I had to think of the expected values of some of these functions before hand. Some of the functions had a lot of calculations and it was a little annoying to do it by hand to make sure it was correct. Other than that, I think unit testing and TDD are a very important aspect of software development.

# Screencasts
You can find the screencasts in the in the [Screencasts](https://github.com/SohrabRoohi/PPA1-Unit-Testing/tree/master/Screencasts) folder (RootFolder/Screencasts).
>>>>>>> d64fa71a04e68f34f8e417d7c71963941734956f
