using System.Text;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // ===== ПРИКЛАД 1: Найпростіший метод (без параметрів, без return) =====
            Console.WriteLine("📌 ПРИКЛАД 1: Простий метод без параметрів");
            Console.WriteLine("─────────────────────────────────────────────");
            Example1_SimpleMethod();

            // ===== ПРИКЛАД 2: Метод з одним параметром =====
            Console.WriteLine("\n📌 ПРИКЛАД 2: Метод з одним параметром");
            Console.WriteLine("─────────────────────────────────────────────");
            Example2_MethodWithParameter();

            // ===== ПРИКЛАД 3: Метод з декількома параметрами =====
            Console.WriteLine("\n📌 ПРИКЛАД 3: Метод з декількома параметрами");
            Console.WriteLine("─────────────────────────────────────────────");
            Example3_MethodWithMultipleParameters();

            // ===== ПРИКЛАД 4: Метод що повертає значення (return int) =====
            Console.WriteLine("\n📌 ПРИКЛАД 4: Метод що повертає число");
            Console.WriteLine("─────────────────────────────────────────────");
            Example4_MethodWithReturn();

            // ===== ПРИКЛАД 5: Метод що повертає текст (return string) =====
            Console.WriteLine("\n📌 ПРИКЛАД 5: Метод що повертає текст");
            Console.WriteLine("─────────────────────────────────────────────");
            Example5_MethodReturnString();

            // ===== ПРИКЛАД 6: Метод з логікою (умовні оператори) =====
            Console.WriteLine("\n📌 ПРИКЛАД 6: Метод з логікою усередину");
            Console.WriteLine("─────────────────────────────────────────────");
            Example6_MethodWithLogic();

            // ===== ПРИКЛАД 7: Метод з циклом =====
            Console.WriteLine("\n📌 ПРИКЛАД 7: Метод з циклом");
            Console.WriteLine("─────────────────────────────────────────────");
            Example7_MethodWithLoop();

            // ===== ПРИКЛАД 8: Один метод викликає інший метод =====
            Console.WriteLine("\n📌 ПРИКЛАД 8: Методи викликають один одного");
            Console.WriteLine("─────────────────────────────────────────────");
            Example8_NestedMethodCalls();

            // ===== ПРИКЛАД 9: Практичний приклад із реальним життям =====
            Console.WriteLine("\n📌 ПРИКЛАД 9: Практичний приклад - калькулятор");
            Console.WriteLine("─────────────────────────────────────────────");
            Example9_Calculator();

            // ===== ПРИКЛАД 10: Метод з опціональними параметрами =====
            Console.WriteLine("\n📌 ПРИКЛАД 10: Метод з опціональними параметрами");
            Console.WriteLine("─────────────────────────────────────────────");
            Example10_OptionalParameters();

            // ===== ПРИКЛАД 11: Перевантаження методів =====
            Console.WriteLine("\n📌 ПРИКЛАД 11: Перевантаження методів");
            Console.WriteLine("─────────────────────────────────────────────");
            Example11_MethodOverloading();

            // ===== ПРИКЛАД 12: Рекурсія =====
            Console.WriteLine("\n📌 ПРИКЛАД 12: Рекурсія");
            Console.WriteLine("─────────────────────────────────────────────");
            Example12_Recursion();

            // ===== ПРИКЛАД 13: Random - Генератор випадкових чисел =====
            Console.WriteLine("\n📌 ПРИКЛАД 13: Random - Генератор випадкових чисел");
            Console.WriteLine("─────────────────────────────────────────────");
            Example13_RandomGenerator();
        }


        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 1: Найпростіший метод
        // ════════════════════════════════════════════════════════════════
        static void Example1_SimpleMethod()
        {
            // Викликаємо метод
            PrintWelcome();
            PrintWelcome();
            PrintWelcome();
        }

        // Метод без параметрів, без повернення значення
        static void PrintWelcome()
        {
            Console.WriteLine("👋 Ласкаво просимо на урок Methods!");
        }


        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 2: Метод з одним параметром
        // ════════════════════════════════════════════════════════════════
        static void Example2_MethodWithParameter()
        {
            // Параметр - це дані, які ми передаємо методу
            GreetStudent("Марія");
            GreetStudent("Іван");
            GreetStudent("Сергій");
        }

        // Метод приймає одне значення (параметр)
        static void GreetStudent(string studentName)
        {
            Console.WriteLine($"Hello, {studentName}! 🎉");
        }


        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 3: Метод з декількома параметрами
        // ════════════════════════════════════════════════════════════════
        static void Example3_MethodWithMultipleParameters()
        {
            // Передаємо декілька значень
            PrintStudentInfo("Анна", 11);
            PrintStudentInfo("Петро", 10);
            PrintStudentInfo("Оля", 11);
        }

        // Метод приймає два параметри: текст і число
        static void PrintStudentInfo(string name, int age)
        {
            Console.WriteLine($"👤 Ім'я: {name}");
            Console.WriteLine($"📅 Вік: {age} років");
            Console.WriteLine();
        }


        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 4: Метод що повертає значення (return)
        // ════════════════════════════════════════════════════════════════
        static void Example4_MethodWithReturn()
        {
            // Метод повертає число і ми його зберігаємо
            int result = Add(5, 3);
            Console.WriteLine($"5 + 3 = {result}");

            int sum = Add(10, 20);
            Console.WriteLine($"10 + 20 = {sum}");

            // Можна одразу вивести результат
            Console.WriteLine($"7 + 8 = {Add(7, 8)}");
        }

        // Метод що повертає число
        static int Add(int a, int b)
        {
            int result = a + b;
            return result; // Повертаємо результат
        }

        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 5: Метод що повертає текст
        // ════════════════════════════════════════════════════════════════
        static void Example5_MethodReturnString()
        {
            // Метод повертає текст
            string message1 = CreateMessage("Марія");
            Console.WriteLine(message1);

            string message2 = CreateMessage("Дмитро");
            Console.WriteLine(message2);
        }

        // Метод що повертає текст (string)
        static string CreateMessage(string name)
        {
            string greeting = $"Привіт, {name}! Як справи? 😊";
            return greeting;
        }


        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 6: Метод з логікою (if/else)
        // ════════════════════════════════════════════════════════════════
        static void Example6_MethodWithLogic()
        {
            // Метод робить різні речі залежно від умови
            CheckAge(8);
            CheckAge(12);
            CheckAge(16);
        }

        // Метод з умовним оператором
        static void CheckAge(int age)
        {
            if (age < 10)
            {
                Console.WriteLine($"✏️  Вік {age}: Ти ще новачок в школі!");
            }
            else if (age >= 10 && age < 13)
            {
                Console.WriteLine($"✏️  Вік {age}: Ти молодший школяр!");
            }
            else
            {
                Console.WriteLine($"✏️  Вік {age}: Ти старший школяр!");
            }
        }


        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 7: Метод з циклом
        // ════════════════════════════════════════════════════════════════
        static void Example7_MethodWithLoop()
        {
            PrintNumbers(5);
            Console.WriteLine();
            PrintStars(7);
        }

        // Метод з циклом for
        static void PrintNumbers(int count)
        {
            Console.Write("Числа: ");
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        // Ще один метод з циклом
        static void PrintStars(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("⭐ ");
            }

            Console.WriteLine();
        }


        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 8: Один метод викликає інший метод
        // ════════════════════════════════════════════════════════════════
        static void Example8_NestedMethodCalls()
        {
            // Викликаємо метод, який у середині себе викликає інші методи
            PrintBigMessage("Methods", "Це дуже круто!");
        }

        // Цей метод викликає три інші методи
        static void PrintBigMessage(string title, string text)
        {
            PrintSeparator();
            Console.WriteLine($"🎯 {title}");
            PrintSeparator();
            Console.WriteLine(text);
            PrintSeparator();
        }

        // Допоміжний метод
        static void PrintSeparator()
        {
            Console.WriteLine("═══════════════════════════════════");
        }

        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 9: Практичний приклад - калькулятор
        // ════════════════════════════════════════════════════════════════
        static void Example9_Calculator()
        {
            // Практичний приклад: простий калькулятор
            int a = 15;
            int b = 7;

            Console.WriteLine($"Число А: {a}");
            Console.WriteLine($"Число Б: {b}");
            Console.WriteLine();

            Console.WriteLine($"➕ Додавання:  {a} + {b} = {Add(a, b)}");
            Console.WriteLine($"➖ Віднімання: {a} - {b} = {Subtract(a, b)}");
            Console.WriteLine($"✖️  Множення:  {a} × {b} = {Multiply(a, b)}");

            // Перевірка перед діленням
            if (b != 0)
            {
                Console.WriteLine($"➗ Ділення:    {a} ÷ {b} = {Divide(a, b)}");
            }
        }

        // Метод для віднімання
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Метод для множення
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Метод для ділення
        static double Divide(int a, int b)
        {
            return (double)a / b; // Повертаємо дробове число
        }

        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 10: Метод з опціональними параметрами
        // ════════════════════════════════════════════════════════════════
        static void Example10_OptionalParameters()
        {
            // Опціональні параметри - це параметри з значеннями за замовчуванням
            // Ми можемо викликати метод без передачі всіх параметрів

            Console.WriteLine("Викликаємо метод без всіх параметрів:");
            CreateBook(); // Використовуємо всі значення за замовчуванням

            Console.WriteLine("\nПередаємо тільки назву:");
            CreateBook("Гаррі Поттер");

            Console.WriteLine("\nПередаємо назву і автора:");
            CreateBook("Собака Баскервілів", "Артур Конан Дойл");

            Console.WriteLine("\nПередаємо всі параметри:");
            CreateBook("1984", "Джордж Оруел", 1949);
        }

        // Метод з опціональними параметрами
        // Кожен параметр має значення за замовчуванням
        static void CreateBook(string title = "Невідома книга", string author = "Невідомий автор", int year = 2024)
        {
            Console.WriteLine($"📚 Книга: {title}");
            Console.WriteLine($"✍️  Автор: {author}");
            Console.WriteLine($"📅 Рік видання: {year}");
            Console.WriteLine();
        }

        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 11: Перевантаження методів (Method Overloading)
        // ════════════════════════════════════════════════════════════════
        static void Example11_MethodOverloading()
        {
            // Перевантаження - коли у нас є кілька методів з одним ім'ям,
            // але з різними параметрами
            // C# вибирає правильний метод залежно від того, які параметри ми передаємо

            Console.WriteLine("Викликаємо Print з одним числом:");
            Print(42);

            Console.WriteLine("\nВикликаємо Print з двома числами:");
            Print(10, 20);

            Console.WriteLine("\nВикликаємо Print з трьома числами:");
            Print(5, 15, 25);

            Console.WriteLine("\nВикликаємо Print з текстом:");
            Print("Привіт, світе!");

            Console.WriteLine("\nВикликаємо Print з числом і текстом:");
            Print(100, "балів");

            Console.WriteLine("\nВикликаємо Print зі списком чисел:");
            Print(new int[] { 1, 2, 3, 4, 5 });
        }

        // Перший варіант: Print з одним int параметром
        static void Print(int number)
        {
            Console.WriteLine($"📌 Число: {number}");
        }

        // Другий варіант: Print з двома int параметрами
        static void Print(int number1, int number2)
        {
            Console.WriteLine($"📌 Числа: {number1} і {number2}");
            Console.WriteLine($"   Сума: {number1 + number2}");
        }

        // Третій варіант: Print з трьома int параметрами
        static void Print(int number1, int number2, int number3)
        {
            Console.WriteLine($"📌 Числа: {number1}, {number2}, {number3}");
            Console.WriteLine($"   Сума: {number1 + number2 + number3}");
        }

        // Четвертий варіант: Print з string параметром
        static void Print(string text)
        {
            Console.WriteLine($"📌 Текст: {text}");
        }

        // П'ятий варіант: Print з int і string параметрами
        static void Print(int number, string text)
        {
            Console.WriteLine($"📌 Результат: {number} {text}");
        }

        // Шостий варіант: Print з масивом чисел
        static void Print(int[] numbers)
        {
            Console.WriteLine($"📌 Масив чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"   [{i}] = {numbers[i]}");
            }
        }

        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 12: Рекурсія (Recursion)
        // ════════════════════════════════════════════════════════════════
        static void Example12_Recursion()
        {
            // Рекурсія - це коли метод викликає сам себе
            // Важливо мати БАЗОВИЙ ВИПАДОК, щоб уникнути нескінченного циклу

            Console.WriteLine("🔄 Рекурсія - Зворотній відлік:");
            Countdown(5);

            Console.WriteLine("\n🔄 Рекурсія - Сума чисел:");
            int sum = SumNumbers(5);
            Console.WriteLine($"Сума чисел від 1 до 5 = {sum}");

            Console.WriteLine("\n🔄 Рекурсія - Піраміда:");
            DrawPyramid(5);
        }

        // ─────────────────────────────────────────────────────────────────
        // Приклад 1: Зворотній відлік
        // ─────────────────────────────────────────────────────────────────
        static void Countdown(int n)
        {
            // БАЗОВИЙ ВИПАДОК - коли зупиняємо рекурсію
            if (n == 0)
            {
                Console.WriteLine("🚀 Пуск!");
                return;
            }

            // РЕКУРСИВНИЙ ВИПАДОК - метод викликає себе
            Console.WriteLine($"⏳ {n}...");
            Countdown(n - 1); // Викликаємо самі себе з меншим числом
        }

        // ─────────────────────────────────────────────────────────────────
        // Приклад 2: Сума чисел від 1 до N
        // ─────────────────────────────────────────────────────────────────
        static int SumNumbers(int n)
        {
            // БАЗОВИЙ ВИПАДОК
            if (n == 0)
            {
                return n;
            }

            // РЕКУРСИВНИЙ ВИПАДОК
            // Sum(5) = 5 + Sum(4)
            // Sum(4) = 4 + Sum(3)
            // Sum(3) = 3 + Sum(2)
            // Sum(2) = 2 + Sum(1)
            // Sum(1) = 1 + Sum(0)
            // Sum(0) = 0
            return n + SumNumbers(n - 1);
        }

        // ─────────────────────────────────────────────────────────────────
        // Приклад 3: Піраміда зірочок
        // ─────────────────────────────────────────────────────────────────
        static void DrawPyramid(int n)
        {
            // БАЗОВИЙ ВИПАДОК
            if (n == 0)
            {
                return;
            }

            // РЕКУРСИВНИЙ ВИПАДОК (креслимо малу піраміду спочатку)
            DrawPyramid(n - 1);

            // Потім креслимо поточний рівень
            for (int i = 0; i < n; i++)
            {
                Console.Write("⭐ ");
            }

            Console.WriteLine();
        }

        // ════════════════════════════════════════════════════════════════
        // ПРИКЛАД 13: Random - Генератор випадкових чисел
        // ════════════════════════════════════════════════════════════════
        static void Example13_RandomGenerator()
        {
            Console.WriteLine("🎲 Random - Генератор випадкових чисел\n");

            // ─────────────────────────────────────────────────────────────────
            // Приклад 1 Випадкове число від 1 до 10
            // ─────────────────────────────────────────────────────────────────
            Console.WriteLine("📍 Приклад 1: Випадкове число від 1 до 10");
            Console.WriteLine("─────────────────────────────────────────────");
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(1, 11); // від 1 до 10
                Console.WriteLine($"🎲 Число {i + 1}: {randomNumber}");
            }
            
            // ─────────────────────────────────────────────────────────────────
            // СИТУАЦІЯ 2: Випадковий колір
            // ─────────────────────────────────────────────────────────────────
            Console.WriteLine("\n📍 СИТУАЦІЯ 4: Випадковий колір");
            Console.WriteLine("─────────────────────────────────────────────");
            PrintRandomColors();
        }

        // ═════════════════════════════════════════════════════════════════════
        // СИТУАЦІЯ 4: Випадковий колір
        // ═════════════════════════════════════════════════════════════════════
        static void PrintRandomColors()
        {
            Random random = new Random();
            string[] colors =
                { "🔴 Червоний", "🟡 Жовтий", "🟢 Зелений", "🔵 Синій", "🟣 Фіолетовий", "⚫ Чорний", "⚪ Білий" };

            Console.WriteLine("Випадкові кольори:\n");

            for (int i = 0; i < 7; i++)
            {
                int randomIndex = random.Next(colors.Length); // Випадковий індекс
                Console.WriteLine($"Колір {i + 1}: {colors[randomIndex]}");
            }
        }
    }
}