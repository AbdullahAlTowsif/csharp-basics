// To Create a Project: dotnet new console -n project_name
// To Run the Project: dotnet run file_name

Console.WriteLine("Hello, World!");
Console.WriteLine("This is a sample C# program.");

Console.Write("Hello ");
Console.WriteLine("World");

Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
Console.WriteLine(name);

int a = 20;
int b = 10;
string c = "Abdullah Al Towsif";
Console.WriteLine("The name is: " + c);

// taking int as input
Console.Write("What is your age: ");
int age = int.Parse(Console.ReadLine() ?? "0");

// string interpolation
Console.WriteLine($"{a} + {b} = {a+b}");

Console.WriteLine("\"Hi\" I\'m Abdullah Al Towsif");
