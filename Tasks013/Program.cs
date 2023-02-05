/*Задайте значения M и N.
 Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"*/

using static System.Console;
Clear();


WriteLine("Ведите число m:  ");
int m = int.Parse(ReadLine()!);
WriteLine("Введите число n:  ");
int n = int.Parse(ReadLine()!);
string result=GetNumbers(n);
WriteLine(result);



string GetNumbers (int num)
{
    if (num == m) return num.ToString();
    else return $"{GetNumbers(num-1)},{num}";
}

