// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным

Console.WriteLine("Введите число от 1 до 7");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);

if (number >= 6)
{
    Console.WriteLine ("Да");
}

else

Console.WriteLine ("Нет");