// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


double[] CreateArray(double[] array)

{
    int Lenght = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 20 - 10;
    }


    return array;
}

double DifferenceMaxMin(double[] array)
{
    double difference = 0;
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

        else if (array[i] < min)
        {
            min = array[i];
        }

        if (min <= 0 && max <= 0)
        {
            difference = (max * (-1) + min * (-1)) * (-1);
        }

        if (min >= 0 && max >= 0)
        {
            difference = max - min;
        }

        if (min <= 0 && max >= 0)
        {
            difference = max - (min * (-1));
        }

    }
    Console.WriteLine(" Максимум = " + max.ToString("N2"));
    Console.WriteLine(" Минимум = " + min.ToString("N2"));
    Console.WriteLine();

    Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + difference.ToString("N2"));
    Console.WriteLine();

    return difference;

}

void PrintArray(double[] array)
{
    Console.WriteLine("Задан массив:");
    Console.WriteLine();

    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i].ToString("N2"));

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}

double[] array = new double[8];
CreateArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
DifferenceMaxMin(array);
Console.WriteLine();