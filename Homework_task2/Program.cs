// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел

Console.WriteLine("Введите первое целое число");
string? numberStringA = Console.ReadLine();
int numberA = int.Parse(numberStringA!);
Console.WriteLine("Введите второе целое число");
string? numberStringB = Console.ReadLine();
int numberB = int.Parse(numberStringB!);
Console.WriteLine("Введите третье целое число");
string? numberStringC = Console.ReadLine();
int numberC = int.Parse(numberStringC!);
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);