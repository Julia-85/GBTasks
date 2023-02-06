/*Напишите программу реализующую метод вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
using static System.Console;

WriteLine("Введите число M:");
int numberM = int.Parse(ReadLine()!);
WriteLine("Введите число N:");
int numberN = int.Parse(ReadLine()!);

int result= AckermannFunction(numberM, numberN);
WriteLine($"Функция Аккермана = {result}");




int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

