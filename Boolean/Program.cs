bool a = true;
bool b = false;

Console.WriteLine(a);
Console.WriteLine(b);

//Для порівняння рівності значень в C# використовується == (два знаки дорівнює)
int num = 0;
int num2 = 5;

bool d = num == num2;
bool e = num < num2;
bool f = num > num2;
bool j = num >= num2;
bool k = num <= num2;
bool l = num != num2;

Console.WriteLine("Is first number equal to second: " + d);
Console.WriteLine($"Is first number smaller than second: {e}");
Console.WriteLine("Is first number bigger than second: {0}", f);
Console.WriteLine("Is first number bigger than or equal to second: {0}", j);
Console.WriteLine("Is first number smaller than or equal to second: {0}", k);
Console.WriteLine("Is first number not equal to second: {0}", l);