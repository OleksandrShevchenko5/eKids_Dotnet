int[] numbers = { 4, 1, 10, -3, 20, 15, 2, 100, -4 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 10)
    {
        Console.WriteLine(numbers[i]);
    }
}