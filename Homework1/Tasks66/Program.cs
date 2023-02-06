/*Напишите программу, которая реализует рекурсивный метод 
нахождения суммы натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
using static System.Console;

WriteLine("Ведите число m:  ");
int m = int.Parse(ReadLine()!);
WriteLine("Введите число n:  ");
int n = int.Parse(ReadLine()!);
  if (m>n)
    {
        int temp=0;
        temp=m;
        m=n;
        n=temp;  
    }



void GetSumm (int m, int n, int summ)
{
    if (m > n) 
    {
        WriteLine($"Сумма : {summ}"); 
        return;
    }
    summ = summ + (m++);
    GetSumm(m, n, summ);
}

GetSumm(m, n, 0);

