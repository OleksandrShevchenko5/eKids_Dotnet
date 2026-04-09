
int[] numbers = { 4, 1, 10, -3, 20, 15, 2, 100, -4 };

//Виводимо всі значення з масиву
foreach (var item in numbers)
{
    Console.Write(item + " ");
}
Console.WriteLine();

//----------------------------------------------------------------------------------------------------------------

var daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

//Виводимо всі дні тижня, які містять літеру 'o'
foreach (var item in daysOfWeek)
{
    if (item.Contains('o'))
    {
        Console.Write(item + " ");
    }
}
Console.WriteLine();