Console.WriteLine("Enter your name:");
string username = Console.ReadLine();

if (username == "")
{
    Console.WriteLine("Your name should not be empty!");
}

//---------------------------------------------------------------------------------

Console.WriteLine("Enter your password:");
string password = Console.ReadLine();

if (password != "")
{
    Console.WriteLine("Your password accepted!");
}
else
{
    Console.WriteLine("Your password should not be empty!");
}

//----------------------------------------------------------------------------------

Console.WriteLine("Enter your email:");
string email = Console.ReadLine();

if (email == "")
{
    Console.WriteLine("Your email should not be empty!");
}
else if (!email.Contains('@'))
{
    Console.WriteLine("Your email should contain '@' symbol!");
}
else
{
    Console.WriteLine("Your email accepted!");
}


//------------------------------------------------------------------------------------
Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your height:");
int height = int.Parse(Console.ReadLine());

//Прийшовши в парк атракціонів, ми бачимо що на один з атракціонів можна увійти тільки якщо Ви старше 8 років та вище за 120 сантиметрів
//На другий - Якщо старше 8 років АБО вище за 120 сантиметрів

//Перший атракціон:
if (age > 8 &&  height > 120)
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Sorry!");
}

//Другий атракціон:
if (age > 8 ||  height > 120)
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Sorry!");
}