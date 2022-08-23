// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumNumbers(int number)
{
    int sum = 0;

    while (number != 0)
    {
        int A = 0;
        A = number % 10;
        number = number / 10;
        sum += A;

    }

    return sum;
}

Console.WriteLine("Ведите число: ");
int number = int.Parse(Console.ReadLine()!);

int sum = SumNumbers(number);
Console.WriteLine("Сумма цифр в числе = " + sum);

