//  Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintReverse(array, array.Length - 1);
    }

    static void PrintReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.WriteLine(array[index]);
        PrintReverse(array, index - 1);
    }
} 