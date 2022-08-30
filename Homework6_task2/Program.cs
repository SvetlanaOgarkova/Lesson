// Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Coordinats(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Линии паралельны и не пересекаются");
    }
    else
    {
        double x = -(b1 - b2) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine();
        Console.WriteLine("Точка пересечения двух прямых(" + x.ToString("N2") + ";" + y.ToString("N2") + ")");
    }

}

Console.Write("Введите (b1) ");
double.TryParse(Console.ReadLine(), out var b1);

Console.Write("Введите (k1) ");
double.TryParse(Console.ReadLine(), out var k1);

Console.Write("Введите (b2) ");
double.TryParse(Console.ReadLine(), out var b2);

Console.Write("Введите (k2) ");
double.TryParse(Console.ReadLine(), out var k2);

Coordinats(b1, k1, b2, k2);



