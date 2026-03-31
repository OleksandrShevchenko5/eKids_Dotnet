int number = 12;
bool isEqualToEleven = number.Equals(11);

Console.WriteLine("Is number equal to eleven: " + isEqualToEleven);
//---------------------------------------------------------

string username = "Sally";

bool a = username.Contains('a');
string b = username.Substring(0, 2);
char c = username.First();
char d = username.Last();
string f = username.Replace('a', 'b');
string h = username.ToUpper();
string i = username.ToLower();

Console.WriteLine("Does username contain letter 'a': " + a);
Console.WriteLine("Username after cutting first 3 letters: " + b);
Console.WriteLine("First letter: " + c);
Console.WriteLine("Last letter: " + d);
Console.WriteLine($"Old username: {username}. New username: {f}");
Console.WriteLine("Username in big letters: " + h);
Console.WriteLine("Username in small letters: " + i);