////Способи створення масивів:

//=========== Одновимірні масиви ===========

//==Оголошення із заданим розміром (без інінціалізації)==
//Ви створюєте "порожній" масив певної довжини.
//Елементи заповнюються значеннями за замовчуванням (для чисел це 0, для string - null).

int[] emptyArrayOfNumbers = new int[5]; // створиться порожній масив з п'яти нулів
string[] emptyArrayOfStrings = new string[3]; // створиться порожній масив з трьох null



//==Оголошення з ініціалізацією значень==
//Ви одразу вказуєте, які дані мають бути в масиві. Компілятор сам порахує довжину.

// Повний запис
// вказуємо тип масиву і надаємо дані які мають бути в масиві,
// довжина розраховується автоматично під час компіляції програми
// і таким чином програмам сама встановить довжину масиву
string[] weekend = new string[] { "Saturday", "Sunday" }; // довжина буде 2

// --Запис з неявною типізацією--
// Вказуємо лише дані які мають бути в масиві,
// довжина, та тип даних розраховуються автоматично
var arrayOfDoubles = new[] { 10.5, 20.0, 15.75 }; // Тип буде double[], довжина - 3

// --Спрощені записи--
// (найпопулярніший)
string[] colors = { "Red", "Green", "Blue" };
// (найсучасніший та найкоротший запис)
int[] dayNumbers = [1, 2, 3, 4, 5];


//----Поради щодо використання----
// new int[10] — коли знаєте тільки кількість елементів.
//  { 1, 2, 3 } або [1, 2, 3] — коли знаєте самі значення.


// ======= Читання елементів, Властивості та деякі методи масивів ========
int[] numbers = [4, 12, 456, 38, -56, 19, 54, 23];

int firstNumberByIndex = numbers[0];
int firstNumberViaMethod = numbers.First();

int lastNumberWithHurdcodedIndex = numbers[7];
int lastNumberViaIndexFromArrayEnd = numbers[^1];
int lastNumberViaMethod = numbers.Last();
int arrayLength = numbers.Length;
int arrayMax = numbers.Max();
int arrayMin = numbers.Min();

Console.WriteLine("First number by index: " + firstNumberByIndex);
Console.WriteLine("First number via method: " + firstNumberViaMethod);
Console.WriteLine("Last number with hardcoded index: " + lastNumberWithHurdcodedIndex);
Console.WriteLine("Last number via index: " + lastNumberViaIndexFromArrayEnd);
Console.WriteLine("Last number via method: " + lastNumberViaMethod);
Console.WriteLine("Array size: " + arrayLength);
Console.WriteLine("Array max number: " + arrayMax);
Console.WriteLine("Array min number: " + arrayMin);

Array.Sort(numbers);
Console.WriteLine("Sorted array");
Array.ForEach(numbers, n => Console.Write(n + ", "));
Console.WriteLine();


Array.Reverse(numbers);
Console.WriteLine("Reverted array");
Array.ForEach(numbers, n => Console.Write($"{n}, "));
Console.WriteLine();


//===========2D або двовимірні масиви=============
// Оголошення без інінціалізації
// Ви вказуєте лише розміри (рядки та стовпці).
int[,] twoDimensionalEmptyArray = new int[3, 4]; // створиться порожній 2D масив з 3 рядками та 4 стовпцями, заповнений нулями

// --Запис з неявною типізацією--
// Вказуємо лише дані які мають бути в масиві,
// довжина, та тип даних розраховуються автоматично
string[,] cinemaHall = {
    { "James", "Robert", "Mary", "Michael" },   // Row 0
    { "Linda", "Susan", "John", "Sarah" },      // Row 1
    { "David", "Karen", "Thomas", "Emily" }     // Row 2
};


Console.WriteLine(cinemaHall[2, 1]); //Хто сидить у 3 рядку на 2 місці? (Karen)
Console.WriteLine(cinemaHall[cinemaHall.GetLength(0) - 1, cinemaHall.GetLength(1) - 1]); //Хто сидить у останньому рядку на останньому місці? (Emily)
