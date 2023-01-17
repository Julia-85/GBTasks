// Напишите программу, реализующую метод,
// который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;

WriteLine("Введите число: ");
int num = int.Parse(ReadLine()!);

int sum= GetSum(num);
WriteLine($"{sum}");


int GetSum(int a)
{
    int b = 0;
    while(a>0)
    {
        b+=a%10;
        a=a/10;
    }
  return b;
}