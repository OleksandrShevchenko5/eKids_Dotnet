//Світлофор
Console.WriteLine("Enter the color:");
string color = Console.ReadLine();

switch (color)
{
    case "Green":
        Console.WriteLine("Переходимо дорогу");
        break;
    case "Yellow":
    case "Red":
        Console.WriteLine("Чекаємо на зелений!");
        Console.WriteLine("Переходимо дорогу");
        break;
    default:
        Console.WriteLine("Переходимо дорогу за правилами дорожнього руху як нерегульований пішохідний перехід, дивлячись ліворуч та праворуч");
        break;
}