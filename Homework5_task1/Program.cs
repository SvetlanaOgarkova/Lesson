// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] CreateArray(int[] array)

{
    int Lenght = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }


    return array;
}

int CountEventNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }

    Console.WriteLine("Количество чётных чисел в массиве = " + count);
    Console.WriteLine();

    return count;

}

void PrintArray(int[] array)
{
    Console.WriteLine("Задан массив:");
    Console.WriteLine();

    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}

int[] array = new int[8];
CreateArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
CountEventNumber(array);
Console.WriteLine();