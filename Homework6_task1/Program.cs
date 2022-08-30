﻿// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

void InputArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число ");
        int element = int.Parse(Console.ReadLine()!);
        array[i] = element;
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Введёны числа:");
    Console.WriteLine();


    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }


    Console.WriteLine();
}

int QuantityPozitivElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result = result + 1;
        }
    }
    Console.WriteLine($"Количество чисел > 0 =" + result);
    return result;
}


Console.WriteLine("Введите количество чисел: ");
string? Length = Console.ReadLine();
int length = int.Parse(Length!);

int[] array = new int[length];
InputArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
QuantityPozitivElements(array);


