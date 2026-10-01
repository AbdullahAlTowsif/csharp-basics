int i = 1;
while (i <= 5)
{
    Console.WriteLine("Hello, World!");
    i++;
}

for (int j = 1; j <= 5; j++)
{
    Console.WriteLine("Hello, World!");
}

do
{
    Console.WriteLine("Abdullah Al Towsif");
    i++;
} while (i <= 10);

// factorial of a number
int number = 5;
int factorial = 1;

while (number > 1)
{
    factorial *= number;
    number--;
}
Console.WriteLine("Factorial: " + factorial);

for (int k = 0; k < 5; k++)
{
    if (k == 3)
    {
        break;
    }
    Console.WriteLine("Value of k: " + k);
}

// nested loops
for (int p = 1; p <= 5; p++)
{
    for (int q = 1; q <= p; q++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

// Problem
double balance = 100.00;
Console.WriteLine("Choice ");
int choice = int.Parse(Console.ReadLine() ?? "0");
switch (choice)
{
    case 1:
        Console.WriteLine($"Check Balance {balance}");
        break;
    case 2:
        Console.Write("Deposit Money ");
        double money = double.Parse(Console.ReadLine() ?? "0");
        if (money > 0)
        {
            balance += money;
            Console.WriteLine($"You have successfully deposited {money} taka");
            Console.WriteLine($"Your current balance {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
        break;
    case 3:
        Console.WriteLine("Withdraw money ");
        double withdrawMoney = double.Parse(Console.ReadLine() ?? "0");
        if (withdrawMoney <= 0)
        {
            Console.WriteLine("Invalid amount");
        }
        else if (withdrawMoney > balance)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            balance -= withdrawMoney;
            Console.WriteLine($"Your current balance after withdrawing {withdrawMoney} taka is {balance}");
        }
        break;
    case 4:
        Console.WriteLine("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}
