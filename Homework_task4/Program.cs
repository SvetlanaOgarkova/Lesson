// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число от 1 до N");
string? numberString = Console.ReadLine();
int N = int.Parse(numberString!);
int index = N;
Console.WriteLine("Вывод четных чисел:");

while(index>1)
{
  if(index%2 == 0)
    {
      Console.WriteLine (index--);
    }
index --;
}