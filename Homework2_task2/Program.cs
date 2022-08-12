// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);

while (number<0)
{
    number = number*(-1);
}

while (number >= 1000)
{
    number = number/10;
}


if(number > 0 && number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if(number > 99 && number < 1000)
{
    int k= 10;
    int firstnumber = (number / k) * k; 
    int secondnumber = number -  firstnumber;
    Console.WriteLine("Третья цифра = " + secondnumber);
 }

