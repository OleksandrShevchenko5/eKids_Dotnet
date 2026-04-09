Console.WriteLine("WHILE Loop.\n");

// Оголошуємо масив з яким будемо проводити експерименти
int[] numbers = { 4, 1, 10, -3, 20, 15, 2, 100, -4 };


//Виведемо на екран всі елементи масиву
Console.WriteLine("Print all elements");
int i = 0;
while (i < numbers.Length)
{
    Console.Write(numbers[i] + " ");
    i++;
}
Console.WriteLine("\n");


//Надрукуємо на екран елементи масив з кінця до початку
Console.WriteLine("Print elements from End to Start (#1)");
int j = numbers.Length - 1;
while (j >= 0)
{
    Console.Write($"{numbers[j]} ");
    j--;
}
Console.WriteLine("\n");


//Надрукуємо на екран елементи масив з кінця до початку (в інший спосіб)
Console.WriteLine("Print elements from End to Start (#2)");
int k = 1;
while (k <= numbers.Length)
{
    Console.Write($"{numbers[^k]} ");
    k++;
}
Console.WriteLine("\n");