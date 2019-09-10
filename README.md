# PPA1-Unit-Testing
# Organization
The assignment was completed in C# .NET Core for which Microsoft Visual Studio 2019 was utilized to create the functions and MSUnit tests. 
##### Project Structure
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

##### Naming
Following C# conventions classes and functions are named in PascalCase. The unit tests are are also named in PascalCase and have a word in them to identify which function it is testing (e.g. BMITest() or RetireTest()).

##### Test Functionality

The tests will use multiple assert statements to test the different cases of the specified functions. Invalid input (such as negative numbers) will be given and appropriate output should also match that.

