/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
*/

void PrintArray(string[] array)
{
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) // ставим запятую после элемента, если это не последний элемент
            Console.Write(", ");
    }
    Console.WriteLine(" }\n");
}

string[] СreateFilteredArray(string[] array, int requiredLength = 3)
{
    string trueIndexes = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= requiredLength)
        {
            trueIndexes += $"{i}";
        }
    }

    string[] sortedArray = new string[trueIndexes.Length];
    for (int i = 0; i < sortedArray.Length; i++)
    {
        sortedArray[i] = array[int.Parse(trueIndexes[i].ToString())]; // приводим trueIndexes[i] к string, затем полученное значение приводим к int и используем как индекс строки.
    }

    return sortedArray;
}

string[] MakeUserArray()
{
    string stringOfWords = String.Empty;
    string inputedString = String.Empty;
    int iterationCounter = 1;

    System.Console.WriteLine("Вас приветствует Мастер создания массива строк.\nПосле ввода всех строк оставьте строку пустой и нажмите Enter.");

    while (true)
    {
        Console.Write($"{iterationCounter}. Введите строку >: ");
        inputedString = Console.ReadLine();

        if (inputedString == "")
        {
            break;
        }
        else if (iterationCounter == 1 )
        {
            stringOfWords += inputedString;
        }
        else
        {
            stringOfWords += "¶" + inputedString;
        }

        iterationCounter++;
    }

    return stringOfWords.Split("¶");
}

// 1. Работа с предсозданным массивом строк.
/*
string[] preCreatedArray = {"hello", "2", "world", ":-)"};
PrintArray(preCreatedArray);
string[] filteredArray = СreateFilteredArray(preCreatedArray);
PrintArray(filteredArray);
*/

// 2. Работа с созданным пользователем массивом строк.
/*
string[] userArray = MakeUserArray();
PrintArray(userArray);
string[] filteredArray = СreateFilteredArray(userArray);
PrintArray(filteredArray);
*/