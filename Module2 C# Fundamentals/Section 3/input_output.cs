/* Section 3: Console Input & Output */

Console.Write("What is your name? ");
string name = Console.ReadLine();
Console.WriteLine(name);

int age = int.Parse(Console.ReadLine());
Console.WriteLine(age);

double price = double.Parse(Console.ReadLine());
Console.WriteLine(price);

Console.Write("Enter Grade A/B/C/D");
char grade = Console.ReadLine()[0];
Console.WriteLine($"Grade: {grade}");

// Input validation
Console.Write("Enter your age: ");
string input = Console.ReadLine();
bool isAgeValid = int.TryParse(input, out int age);

if (isAgeValid)
{
    Console.WriteLine("Your age is valid", age);
}
else
{
    Console.WriteLine("Your age is not valid");
}

double pi = 3.14159;
Console.WriteLine($"Pi: {pi:F2}");
int population = 1420000000;
Console.WriteLine($"Polpulation: {population:N2}");
// right align
Console.WriteLine($"{"Name", 10}:Rahim");

// Calculator
Console.WriteLine("CALCULATOR");
Console.Write("First Number: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Second Number: ");
double secondNumber = double.Parse(Console.ReadLine());

Console.WriteLine($"\n{"Operation",-15}{"Result",10}");
Console.WriteLine($"{"==========",-15}{"=========",10}");

// Console.WriteLine($"{"Addition", -15}{firstNumber + secondNumber, 10}");
// Console.WriteLine($"{"Subtraction", -15}{firstNumber - secondNumber, 10}");
// Console.WriteLine($"{"Multiplication", -15}{firstNumber * secondNumber, 10}");
// Console.WriteLine($"{"Division", -15}{firstNumber / secondNumber, 10}");

// Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber, -10}");
Console.WriteLine($"{firstNumber + " + " + secondNumber,-15}{firstNumber + secondNumber,10:F2}");
