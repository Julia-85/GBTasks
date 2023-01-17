// Напишите программу, реализующую метод,который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B с использованием цикла.

using static System.Console;
WriteLine("Введите число А: ");
int A = int.Parse(ReadLine()!);
WriteLine("Введите число В: ");
int B = int.Parse(ReadLine()!);

int sum = DegNum(A, B);
WriteLine($"{sum}");







int DegNum(int C, int D)
{ 
    int result=1;
    int i=1;
    while(D>=i)
    {
        result*= C;
             i++;
    }
    return result;
}


