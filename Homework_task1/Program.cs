// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее

Console.WriteLine("Введите первое целое число");
string? numberStringA = Console.ReadLine();
int numberA = int.Parse(numberStringA!);
Console.WriteLine("Введите второе целое число");
string? numberStringB = Console.ReadLine();
int numberB = int.Parse(numberStringB!);
if(numberA > numberB)
{
    Console.Write ("max = ");
    Console.WriteLine(numberA);
    Console.Write ("min = ");
    Console.WriteLine(numberB);
}

if(numberA < numberB)
{
    Console.Write ("max = ");
    Console.WriteLine(numberB);
    Console.Write ("min = ");
    Console.WriteLine(numberA);
}

if(numberA == numberB)
{
    Console.WriteLine("Числа равны");
 
}
