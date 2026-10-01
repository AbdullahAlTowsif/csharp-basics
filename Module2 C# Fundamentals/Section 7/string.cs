string name = "Towsif";
// string input = Console.ReadLine();

Console.WriteLine(name[name.Length-1]);

string str = null;
if (string.IsNullOrEmpty(str))
{
    Console.WriteLine("Null");
}
else
{
    Console.WriteLine("Not Null");
}

string num = "42"; // 421111
string paddedNumber = num.PadRight(6, '1');
Console.WriteLine(paddedNumber);

string sentence = "I am learning ASP.NET";
Console.WriteLine(sentence.Contains("learning"));
string part = sentence.Substring(5, 8);
Console.WriteLine(part);

string name1 = "Dr. Rahim";
Console.WriteLine(name1.StartsWith("Dr."));
Console.WriteLine(name1.EndsWith("Rahim"));
Console.WriteLine(name1.IndexOf("R")); // LastIndexOf

string text = "I love c sharp";
string updatedText = text.Replace("c sharp", "Javascript");
Console.WriteLine(updatedText);

string insertedText = text.Insert(7, "Beautiful ");
string removedText = text.Remove(7);
Console.WriteLine(insertedText);
Console.WriteLine(removedText);

string a = "Rahim";
string c = "Rahim";
string b = "RAHIM";

Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase));
Console.WriteLine(a.CompareTo(b));
Console.WriteLine(a.CompareTo(c));
