////Способи створення масивів:
//int[] numbers = new int[3] { 1, 2, 3 }; //Створюємо масив елементів типу INT розміром в 3 елементи
//int[] secondNumbers = new int[] { 1, 2, 3, 5, 6, 7, 8 }; //Створюємо масив елементів типу INT та дозволяємо програмі самій порахувати кількість елементів, які ми передали
////та встановити, таким чином, розмір масиву
//int[] anotherNumbers = [1, 2, 3]; //Спрощене створення масиву, програма бере тип даних відповідно то елементів, які ми додали в масиви

//Console.WriteLine(secondNumbers[0]);//1
//Console.WriteLine(numbers[2] + anotherNumbers[2]);//6

//-----------------------------------------------------------------------------

//int[,] twoDimensionArray = new int[3, 3]
//{
//   { 1, 5, 7 },
//   { 2, 6, 4 },
//   { 4, 5, 6 }
//};

//Console.WriteLine(twoDimensionArray[1, 2]);

//twoDimensionArray[1, 2] = 1;

//Console.WriteLine(twoDimensionArray[1,2]);

//int[][] multiDimensionNumbers = new int[3][];
//multiDimensionNumbers[0] = new int[7];
//multiDimensionNumbers[1] = new int[5] { 2, 4, 6, 7, 8 };
//multiDimensionNumbers[2] = new int[] { 2, 3, 4, 5, 6, 6 };

//------------------------------------------------------------

int[] numbers = [4, 6, 7, 12, 43, 2, 54, 23];

int first = numbers.First();
int last = numbers.Last();
int arrayLength = numbers.Length;
int arrayMax = numbers.Max();
int arrayMin = numbers.Min();

Console.WriteLine("First number: " + first);
Console.WriteLine("Last number: " + last);
Console.WriteLine("Array size: " + arrayLength);
Console.WriteLine("Array max number: " + arrayMax);
Console.WriteLine("Array min number: " + arrayMin);