// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] CreateArray(int[] array)

{
    int Lenght = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 100);
    }


    return array;
}

int SumElementOddPosishional(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }

    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + sum);
    Console.WriteLine();

    return sum;

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

int[] array = new int[10];
CreateArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SumElementOddPosishional(array);
Console.WriteLine();