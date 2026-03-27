string color = "Green";

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

int a = 5;
int b = 6;
int c = 4;

int d = a > b && a > c ? a : b > a && b > c ? b : c;