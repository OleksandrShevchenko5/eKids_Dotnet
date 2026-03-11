Console.Write("This is our second lesson!");
Console.Write("Not the first!");
Console.WriteLine("Not the last!");
Console.Write("Second!");

Console.WriteLine("Key:");
ConsoleKeyInfo key = Console.ReadKey();

Console.WriteLine("String:");
string text = Console.ReadLine();

Console.Clear();

Console.WriteLine("Key: " + key.KeyChar);
Console.WriteLine("String: " + text);