/******************************************************************************
Задача: Написать программу, которая из имеющегося массива строк формирует новый 
массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.

*******************************************************************************/
using System;
class Program
{
    static void Main()
    {
        Console.Clear();
        string[] array = { "Hel", "2", "world", ":-)1", "gt1" };
        string[] newArray = GetNewArray(array);
        Print(newArray);

    }

    static int LengthNewArray(string[] array)
    {
        int count = 0;
        foreach (string el in array)
        {
            if (el.Length <= 3)
                count += 1;
        }
        return count;
    }

    static string[] GetNewArray(string[] array)
    {
        string[] newArray = new string[LengthNewArray(array)];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[j] = array[i];
                j += 1;
            }
        }
        return newArray;
    }

    static void Print(string[] newArray)
    {
        foreach (string el in newArray)
        {
            System.Console.Write($"{el} ");
        }
    }

}