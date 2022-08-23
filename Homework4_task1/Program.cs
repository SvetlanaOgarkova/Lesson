// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//"Напишите ЦИКЛ" значит возводить в степень нужно циклом, а не методом Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Pow(int numberA, int numberB)
{
    int result = 1;

    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine("Ведите число A");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ведите число B");
int numberB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Число А в степени B = ");
int result = Pow(numberA, numberB);
Console.WriteLine(result);




