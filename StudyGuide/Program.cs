// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("What is your name?");
// string name = Console.ReadLine();
// // This is concating the string name to the middle of the Write Line
// Console.WriteLine("Hello "+ name+ "!");
// // This is using Lambda Notation for implementing the input in the Write Line.
// Console.WriteLine($"Hello {name}!");

int myInt = 8;
double myDouble = 8.1;
bool myBool = false;

//Implicit type casting
double x = myInt;
Console.WriteLine($"Implicit type casting an int into a double gives {x}");

// Explicit type casting
int k = (int) myDouble;
double y = (double) myInt;
Console.WriteLine($"Explicitly type casting {myDouble} into int gives {k}");
Console.WriteLine($"Explicitly type casting {myInt} into int gives {y}");
// Type Conversion
Console.WriteLine($"Using string conversion of an int gives {Convert.ToString(myInt)}");
Console.WriteLine($"Using double conversion of an int gives {Convert.ToDouble(myInt)}");
Console.WriteLine($"Using int conversion of a double gives {Convert.ToInt32(myDouble)}");
Console.WriteLine($"Using string conversion of a boolean gives {Convert.ToString(myBool)}");