// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void inputArray(int[] array)
{
    int Lenght = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }

}

void printArray(int[] array)
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
inputArray(array);
Console.WriteLine();
printArray(array);