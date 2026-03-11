char letter = 'a';
char symbol = '*';
char number = '1';
char space = ' ';

string letter1 = "a";
string symbol1 = "*";
string number1 = "1";
string space1 = " ";

//char word = 'Hello';
string word1 = "Hello";

Console.WriteLine(word1);

//----------------------------------------------------------------------------------------------------------------------------

//Як і з числами, ми можемо проводити певні операції також і зі змінними текстових типів
string word = "Hello";
string name = "User";

string sentence = word + name;

Console.WriteLine(sentence);

//Покращимо це речення
//Для цього ми маємо декілька варіантів
string sentence1 = word + ", " + name + '!';

//Символ $ перед значенням додає можливість передавати змінні безпосередньо всередину, використовуючи фігурні дужки
string sentence2 = $"{word}, {name}!";

Console.WriteLine(sentence1);
Console.WriteLine(sentence2);

//---------------------------------------------------------------------------------------------------------------------------


char firstLetter = 'A';
char secondLetter = 'B';

//Здається логічним що якщо додати літери А та В, то ми маємо отримати комбінацію літер "АВ", але ми отримуємо помилку
//string addTwoCharLetters = firstLetter + secondLetter;

//Це виникає через логіку опрацювання таких літер та символів вашою IDE.
//В даній ситуації програма думає таким чином:
//- Вона бачить два символи як саме окремі символи, а не частини тексту
//- Першим ділом вона йде перевіряти до таблиці АSCII чому дорівнюють ці символи
//- Знаходить їх значення в таблиці і бере числовий відповідник
//- Плюсує числові відповідники цих символів
int addTwoCharLettersAsInt = firstLetter + secondLetter;

Console.WriteLine(addTwoCharLettersAsInt);


//Якщо замість хоча б одного з цих Char буде String, то програма розуміє, що тут має бути текст в результаті, тому не йде до таблиці ASCII
//і просто "зклеює" ці два тексти, розуміючи їх вже як текстові елементи.
string firstLetter1 = "A";

string addCharAndString = firstLetter + firstLetter1;

Console.WriteLine(addCharAndString);