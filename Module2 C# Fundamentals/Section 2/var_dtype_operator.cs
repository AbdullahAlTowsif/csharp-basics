/* Section 2: Variables, Data Types & Operators */

string name = "Rahim";
int marks = 85;
bool passed = true;

Console.WriteLine($"Name: {name} his marks: {marks} and passed: {passed}");

float floatSalary = 456.45f;
decimal decimalSalary = 50000.00m;
Console.WriteLine(floatSalary);
Console.WriteLine(decimalSalary);

double a = 0.1 + 0.2;
Console.WriteLine(a);

decimal b = 0.1m + 0.2m;
Console.WriteLine(b);

char text = 'a';
Console.WriteLine(text);

string name1 = "Rahim";
string name2 = "rahim";

Console.WriteLine(name1.ToLower() == name2.ToLower());

// type casting 2 types: Implicit and Explicit
// explicit
double myDouble = 100.50;
int myInt = (int)myDouble;
Console.WriteLine(myInt);

/*
int --> double = implicit
int --> long = implicit
double --> int = explicit
long --> int = explicit
float --> int = explicit
*/
