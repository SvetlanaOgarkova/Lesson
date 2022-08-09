// Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите целое число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);

if(number%2 == 0)
{
    Console.Write("четное = ");
    Console.WriteLine (number);
}
else
{
    Console.Write("нечетное = ");
    Console.WriteLine (number);
}