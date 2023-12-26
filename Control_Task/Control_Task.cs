// Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] InputArrayOfString ()
{
    Console.Write("Введите размера массива строк -> ");
    int sizeOfSoureceArrayString = Convert.ToInt32(Console.ReadLine());
    string[] sourceArrayOfString = new string[sizeOfSoureceArrayString];
    int tempcount = 0;

    while (tempcount < sizeOfSoureceArrayString)
    {
        Console.Write($"Введите {tempcount+1}-ый(ой) элемент массива строк -> ");
        sourceArrayOfString[tempcount] = Console.ReadLine();
        tempcount++;
    }
    return sourceArrayOfString;
}

string[] sourceArrayOfString = InputArrayOfString();
int sizeOfShortWordArray = 0;
int countShortWord = 0;

foreach (var i in sourceArrayOfString)
{
    if (i.Length <= 3) 
        sizeOfShortWordArray++;
}

string[] arrayOfStringShortWord = new string[sizeOfShortWordArray];