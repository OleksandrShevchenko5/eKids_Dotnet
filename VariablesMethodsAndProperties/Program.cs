//Для кожного типу даних та кожної змінної є свої певні функції, які ми можемо використовувати
string username = "Sally";

bool isUsernameContainA = username.Contains('a'); //Перевіряємо чи містить username в собі літеру "а"
string substring = username.Substring(0, 2); //Кажемо програмі взяти 2 символи починаючи з символу під номером 0
                                     //(в програмуванні ми рахуємо завжди починаючи з нуля а не з одиниці) 
char firstLetter = username.First(); //Беремо першу літеру з тексту, збереженого в змінній username
char lastLetter = username.Last(); //Беремо останню літеру з тексту, збереженого в змінній username
string modifiedUsername = username.Replace('a', 'b'); //Замінюємо всі літери "а" в тексті змінної username на "b"
string bigUsername = username.ToUpper(); //Робимо всі літери тексту, збереженого в змінній username, великими
string smallUsername = username.ToLower(); //Робимо всі літери тексту, збережного в змінній username, маленькими

Console.WriteLine("Does username contain letter 'a': " + isUsernameContainA);
Console.WriteLine("Username after cutting first 2 letters: " + substring);
Console.WriteLine("First letter: " + firstLetter);
Console.WriteLine("Last letter: " + lastLetter);
Console.WriteLine($"Old username: {username}. New username: {modifiedUsername}");
Console.WriteLine("Username in big letters: " + bigUsername);
Console.WriteLine("Username in small letters: " + smallUsername);