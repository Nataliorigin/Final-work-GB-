// Задача: Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] FoundLengtString(string[] array, int size)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size) length++;
    }

    string[] newarray = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    
}

PrintArray(array1);
Console.Write($" -> ");
string[] result1 = FoundLengtString(array1, 3);
PrintArray(result1);
Console.WriteLine();

PrintArray(array2);
Console.Write($" -> ");
string[] result2 = FoundLengtString(array2, 3);
PrintArray(result2);
Console.WriteLine();

PrintArray(array3);
Console.Write($" -> ");
string[] result3 = FoundLengtString(array3, 3);
PrintArray(result3);
Console.WriteLine();