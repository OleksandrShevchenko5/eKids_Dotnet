Console.WriteLine("DO-WHILE Loop.\n");
//Особливості циклу do-while:
//Цикл do-while завжди виконується хоча б один раз,
//тому що умова перевіряється після виконання тіла циклу.
//Це корисно, коли потрібно щось зробити принаймні один раз, а потім перевіряти умову

// Оголошуємо масив з яким будемо проводити експерименти
int[] numbers = { 4, 1, 10, -3, 20, 15, 2, 100, -4 };


//Виведемо на екран всі елементи масиву
Console.WriteLine("All elements:");
int i = 0;
do
{
    Console.Write(numbers[i] + " ");
    i++;
} while (i < numbers.Length);
Console.WriteLine("\n");


//Надрукуємо на екран елементи масив з кінця до початку
Console.WriteLine("Array from end to start:");
int j = numbers.Length - 1;
do
{
    Console.Write($"{numbers[j]} ");
    j--;
} while (j >= 0);
Console.WriteLine("\n");


//Виведемо на екран лише ті елементи масиву, які більші або рівні 10
Console.WriteLine("Elements greater than or equal to 10:");
int m = 0;
do
{
    if (numbers[m] >= 10)
    {
        Console.Write($"{numbers[m]} ");
    }
    m++;
} while (m < numbers.Length);
Console.WriteLine("\n");


//Надрукуємо кожний другий елемент масиву, починаючи з першого
Console.WriteLine("Every second element:");
int n = 0;
do
{
    Console.Write($"{numbers[n]} ");
    n += 2;
} while (n < numbers.Length);
Console.WriteLine();