using static System.Console;

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a > 99)
{
 while (a > 999)
{
     a = a/10;
}
WriteLine($"{a%10}");
}
else WriteLine("Третьего числа нет");