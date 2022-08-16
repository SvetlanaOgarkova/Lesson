// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите положительное пятизначное число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int firstnumber = number/1000;
int secondnumber = number %100;

if (number< 10000 || number>99999)
{
Console.WriteLine ("Вы ввели неверное число, введите положительное пятизначное число");
return;
}

if (number>9999 && number< 100000 )

if (firstnumber/10 == secondnumber %10 && firstnumber%10 == secondnumber /10)
    {
    Console.WriteLine ("Является палиндромом число = " + number );
    }
else
    {
    Console.WriteLine ("Не является палиндромом число = " + number );
    }
        
