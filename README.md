# MainMethod

The MainMethod project is a console application that demonstrates the usage of method overloading in C#. It includes a class with three methods, each performing a different math operation and returning the result as an integer. The Main() method of the console app instantiates the class and calls the methods with different parameter types, displaying the results to the screen.

# Project Description
The MainMethod project consists of a single file named Program.cs.

# Program.cs
This file contains the Main() method, which serves as the entry point of the application. It interacts with the user, instantiates an object of the class MathOperations, and calls the methods with different parameter types, displaying the returned integers.

The MathOperations class contains the following methods:

PerformMathOperation(int num)

Takes an integer parameter num.

Performs a math operation on num (e.g., addition, subtraction, etc.).

Returns the result of the math operation as an integer.

PerformMathOperation(decimal num)

Takes a decimal parameter num.

Performs a different math operation on num.

Returns the result of the math operation as an integer.

PerformMathOperation(string num)

Takes a string parameter num.

Converts num to an integer (if possible).

Performs a different math operation on the converted integer.

Returns the result of the math operation as an integer.

# Instructions

Start the console application.

The program will instantiate an object of the MathOperations class.

The program will call the PerformMathOperation(int num) method, passing in an integer.

The returned integer from the method will be displayed on the screen.

Observe the result of the math operation performed on the integer.

The program will then call the PerformMathOperation(decimal num) method, passing in a decimal.

The returned integer from the method will be displayed on the screen.

Observe the result of the math operation performed on the decimal.

Finally, the program will call the PerformMathOperation(string num) method, passing in a string that equates to an integer.

The returned integer from the method will be displayed on the screen.

Observe the result of the math operation performed on the converted integer.

The program will terminate, and you can rerun it to perform calculations with different parameters.

# Skills Demonstrated
This project demonstrates the following skills and concepts related to method overloading and console applications in C#:

Defining and implementing methods with different parameter types

Performing different math operations based on the parameter type

Returning integers from methods

Instantiating objects of a class

Calling methods from the Main() program with different parameters

Displaying integer results to the screen

Handling and converting parameter types (string to integer)
