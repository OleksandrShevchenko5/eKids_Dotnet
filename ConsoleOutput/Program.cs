Console.WriteLine("We can write very long text here but what if we " +
    "need to change lines to make it more readable? In C# we cannot just press" +
    "'Enter' and change the line - we will have it written in one line. What should we do?");

Console.WriteLine(new string('-', 50));

Console.WriteLine("For this purposes we have special combinations: ");
Console.WriteLine("'\\n' - allows us to move text to the next line.\nLike this.");
Console.WriteLine("'\\a' - allows us to make a Beep sound. \a");
Console.WriteLine("\t'\\t' - adds a tab space before the text like 'Tab' button.");
Console.WriteLine("'\\v' - adds a tab space vertically, so you can type text\vlike\vstairs");

Console.WriteLine(new string('-', 50));

//--------------------------------------------------------------------------
//Unfortunately, \n works only for Windows and MacOS systems. If we are developing the app for Linux too, it's much
//better to use universal decision

Console.WriteLine($"We are writing some text and than we use Environment.NewLine to create new row. {Environment.NewLine}." +
    $"This is universal approach that allows us to create new row for all systems");

//-------------------------------------------------------------------------

//Ми можемо писати текст не тільки на початку консолі, а в будь-якому її місці!
//Для цього нам потрібно перенести курсор на потрібну нам позицію і ми одразу можемо продовжувати працювати з цього місця.
Console.Clear();
Console.SetCursorPosition(20, 20);
Console.WriteLine("AAAAA");