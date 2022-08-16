// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату x1");
var Stringx1 = Console.ReadLine();
int x1 = int.Parse(Stringx1!);
Console.WriteLine("Введите координату y1");
var Stringy1 = Console.ReadLine();
int y1 = int.Parse(Stringy1!);
Console.WriteLine("Введите координату z1");
var Stringz1 = Console.ReadLine();
int z1 = int.Parse(Stringz1!);
Console.WriteLine("Введите координату x2");
var Stringx2 = Console.ReadLine();
int x2 = int.Parse(Stringx2!);
Console.WriteLine("Введите координату y2");
var Stringy2 = Console.ReadLine();
int y2 = int.Parse(Stringy2!);
Console.WriteLine("Введите координату z2");
var Stringz2 = Console.ReadLine();
int z2 = int.Parse(Stringz2!);

double distanse = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow (z2-z1, 2));

Console.WriteLine("Расстояние между координатами в 3D пространстве =" +distanse.ToString("N2"));
