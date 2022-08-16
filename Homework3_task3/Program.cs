// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое число от 1 до N");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int index = 1;

if (number<1)
{
    Console.WriteLine("Вы ввели неверное число, введите целое число от 1 до N");
    return;
}   

while(number >= index)

{    
        var result = Math.Pow(index,3);
        index ++;
        Console.WriteLine (result);
}


    
