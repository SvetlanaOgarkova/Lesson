﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (n == 0)
        return AckermanFunction(m - 1, 1);
    else if ((m > 0) && (n > 0))
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    else
        return (n + 1);
}

int n = 3;
int m = 2;

Console.WriteLine($" A({m}, {n}) = " + (AckermanFunction(m, n)));