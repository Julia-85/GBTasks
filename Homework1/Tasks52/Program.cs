/*Напишите программу реализующую методы, 
формирования двумерного массива и
 массива средних арифметических значений каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using static System.Console;


Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Write($"{arr[i, j] ,4}");
    }
   WriteLine();
}

WriteLine();


 WriteLine("Среднее арифметическое каждого столбца:");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Write($" { sum / arr.GetLength(0):f1} ");
}

WriteLine();
