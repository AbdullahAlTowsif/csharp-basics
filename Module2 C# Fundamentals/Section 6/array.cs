int[] marks2 = new int[5];
int[] marks1 = { 90, 80, 70, 60, 50 };

int maxNumber = marks1[0];

for (int i = 0; i < marks1.Length; i++)
{
    if (marks1[i] > maxNumber)
    {
        maxNumber = marks1[i];
    }
}
Console.WriteLine("Maximum number: " + maxNumber);

// 2D array
int[,] seats = new int[5, 4];
seats[0, 0] = 1;
seats[0, 1] = 2;
seats[0, 2] = 3;
seats[0, 3] = 4;

seats[1, 0] = 5;
seats[1, 1] = 6;
seats[1, 2] = 7;
seats[1, 3] = 8;

seats.GetLength(0); // returns number of rows
seats.GetLength(1); // returns number of columns

int[,] grid =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

for (int i = 0; i < grid.GetLength(0); i++)
{
    for (int j = 0; j < grid.GetLength(1); j++)
    {
        Console.Write(grid[i, j] + " ");
    }
    Console.WriteLine();
}

string[] students = { "Rahim", "Karim", "Jabbar" };
string[] subjects = { "Math", "Science", "English" };

int[,] marks =
{
    { 90, 80, 70 },
    { 85, 75, 65 },
    { 95, 85, 75 }
};

Console.Write($"{"Name",-10}");
foreach (string s in subjects)
{
    Console.Write($"{s,-10}");
}

Console.WriteLine("Total");
Console.WriteLine(new string('-', 60));

for (int i = 0; i < students.Length; i++)
{
    Console.Write($"{students[i],-10}");
    int total = 0;
    for (int j = 0; j < subjects.Length; j++)
    {
        Console.Write($"{marks[i, j],-10}");
        total += marks[i, j];
    }
    Console.WriteLine(total);
}

// built-in methods
int[] numbers = { 5, 2, 8, 8, 81, 4 };
Array.Sort(numbers);
Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));

Array.Reverse(numbers);
Console.WriteLine("Reversed numbers: " + string.Join(", ", numbers));

int index = Array.IndexOf(numbers, 78);
int index2 = Array.IndexOf(numbers, 8);

Console.WriteLine("Index of 78: " + index);
Console.WriteLine("Index of 8: " + index2);

int lastIndex = Array.LastIndexOf(numbers, 8); // last er dik theke koto index e 8 ache ta ber kore dibe
Console.WriteLine("Last index of 8: " + lastIndex);

int[] copiedNumbers = new int[5];
Array.Copy(numbers, copiedNumbers, 5);
Console.WriteLine("Copied numbers: " + string.Join(", ", copiedNumbers));

Array.Clear(copiedNumbers, 0, 3); // 0 theke 3 ta element clear kore dibe
Console.WriteLine("Cleared copied numbers: " + string.Join(", ", copiedNumbers));

Array.Resize(ref numbers, 10); // array size 10 kore dibe
Console.WriteLine("Resized numbers: " + string.Join(", ", numbers));

bool aboveFive = Array.Exists(numbers, n => n > 5); // check if any number is greater than 5
Console.WriteLine("Any number above 5: " + aboveFive);

int foundNumber = Array.Find(numbers, n => n > 5 && n < 10); // find the first number greater than 5 and less than 10
Console.WriteLine("First number above 5 and below 10: " + foundNumber);

int idx = Array.FindIndex(numbers, n => n > 5 && n < 10); // find the index of the first number greater than 5 and less than 10
Console.WriteLine("Index of first number above 5 and below 10: " + idx);

int lastIdx = Array.FindLastIndex(numbers, n => n > 5 && n < 10); // find the index of the last number greater than 5 and less than 10
Console.WriteLine("Last index of number above 5 and below 10: " + lastIdx);