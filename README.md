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

Program.cs - Contains all the CLI code, input/output, and calls the functions desired by the specifications. (This code was not expected to have code coverage as specified)

Functions.cs - Contains the four functions that were described in the assignment specifications. BMI, Retire, Distance, and Split.

UnitTest1.cs - Contains the four unit testing functions that test the functions implemented in Functions.cs. Uses Assert statements to analyze output of the functions.

### Naming
Following C# conventions classes and functions are named in PascalCase. The unit tests are are also named in PascalCase and have a word in them to identify which function it is testing (e.g. BMITest() or RetireTest()).

### Test Functionality

The tests will use multiple assert statements to test the different cases of the specified functions. Invalid input (such as negative numbers) will be given and appropriate output should also match that.

# Setup

This application has been developed for Windows 10, it may also work on Linux but I have not tested it.


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
