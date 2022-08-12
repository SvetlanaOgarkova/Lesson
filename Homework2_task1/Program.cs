// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа


Console.WriteLine("Введите трехзначное число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int firstnumber = 0;
int secondnumber = 0;

while (number<0)
{
    number = number*(-1);
}
if (number>0)
{
firstnumber = number /10;
secondnumber = firstnumber %10;
Console.WriteLine ("Вторая цифра числа = " + secondnumber);
}
