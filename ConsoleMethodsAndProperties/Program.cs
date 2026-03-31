Console.Clear(); //Очищуємо консоль
Console.Beep(); //Вивидимо пікаючий звук консолі
Console.GetCursorPosition(); //Отримуємо інформацію щодо позиції курсору
Console.SetWindowSize(40, 40); //Встановлюємо розмір вікна консолі
Console.WriteLine("  "); //Вивід тексту

Console.BackgroundColor = ConsoleColor.Red; //Встановлюємо фон для тексту в консолі
Console.ForegroundColor = ConsoleColor.Green; //Встановлюємо колір тексту консолі
Console.WriteLine("Some test to see colors");
Console.CursorVisible = false; //Встановлюємо чи відображається курсор в консолі
Console.Title = "My Console"; //Змінюємо назву консолі
Console.WindowWidth = 50; //Змінюємо ширину вікна консолі. Не буде використано в уже відкритій консолі
Console.WindowHeight = 50; //Змінюємо висоту вікна консолі. Не буде використано в уже відкритій консолі