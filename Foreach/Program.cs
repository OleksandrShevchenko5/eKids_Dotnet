using System.Threading.Channels;

int[] numbers = { 4, 1, 10, -3, 20, 15, 2, 100, -4 };

//Виводимо всі значення з масиву
foreach (var item in numbers)
{
    Console.WriteLine(item);
}

//----------------------------------------------------------------------------------------------------------------

var daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

foreach (var item in daysOfWeek)
{
    if (item.Contains('o'))
    {
        Console.WriteLine(item); 
    }
}