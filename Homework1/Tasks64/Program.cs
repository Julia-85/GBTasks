/*Напишите программу, которая реализует рекурсивный метод
 вывода всех натуральных числел в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
using static System.Console;


WriteLine("Ведите число n:  ");
int n = int.Parse(ReadLine()!);

string result = GetNumbers(1);
WriteLine(result);

string GetNumbers (int num)
{
    
    if (num == n) return num.ToString();
    else return $"{GetNumbers(num+1)},{num}";
    
}















/*int GetNumbers (int i)
    {
            Write(i);
            i=i-1;
            if (i > 0)
           GetNumbers(i);
        }*/