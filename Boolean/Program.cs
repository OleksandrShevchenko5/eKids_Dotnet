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

Console.WriteLine("Is first number equal to second: " + d);
Console.WriteLine($"Is first number smaller than second: {e}");
Console.WriteLine("Is first number bigger than second: {0}", f);


//Також ми можемо перевіряти більше ніж одну умову одночасно використовуючи
//&& - означає "та"/"і"
//або
//|| - означає "або"

bool g = num < num2 && a == false; //такий вираз буде дорівнювати true якщо обидва вирази будуть дорівнювати true
bool h = num < num2 || a == false; //такий вираз буде дорівнювати true якщо хоча б один з варіантів буде дорівнювати true

Console.WriteLine("Both conditions are true: " + g);
Console.WriteLine("At lear one condition is true: " + h);