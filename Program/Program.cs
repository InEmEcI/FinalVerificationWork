

// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями. 
// Лучше обойтись исключительно массивами. 

// Примеры:
// ["hello", "2", "word", ":-)"] -> ["2",":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia","Denmark","Kazan"] -> []

Console.Clear();



// Намолняем массив строками 
string[] stringArray = new string[4];
stringArray[0] = "1234";
stringArray[1] = "1567";
stringArray[2] = "-2";
stringArray[3] = "computer science";

// Выводим на эркан наполненный массив
Console.WriteLine($"stringArray: {stringArray[0]}, {stringArray[1]}, {stringArray[2]}, {stringArray[3]}");

// Сортируем массив
ArraySort(stringArray);

// Выводит на экран отсортированный массив строк
Console.Write("Отсортированый массив: ");
PrintArray(ArraySort(stringArray));

/* -------------------------------------------------------------------------- */

// метод, который из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа
string[] ArraySort(string[] array)
{
    string[] newArray = new string[4];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }

    }

    return newArray;
}

//Метод выводит на экран массив
void PrintArray(string[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + " ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

