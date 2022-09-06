//  Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumber(int m, int n)
{
    if (m == n) return n;

    else if (m < n) return n + SumNaturalNumber(m, n - 1);

    else return m + SumNaturalNumber(n, m - 1);

}

int m = 4;
int n = 8;
Console.WriteLine(SumNaturalNumber(m, n));
