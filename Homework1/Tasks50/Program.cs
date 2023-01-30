/*Напишите программу реализующую метод,
принимающий позиции элемента в двумерном массиве,
 и возвращающий значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1;7 -> такого элемента в массиве нет
1;1 -> 9*/

using static System.Console;

Write("Введите строку: ");
int pos1 = Convert.ToInt32(ReadLine()!) - 1;
Write("Введите столбец: ");
int pos2 = Convert.ToInt32(ReadLine()!) - 1;
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] arr = new int[n, m];
WriteLine("Исходный массив: ");

for (int i = 0; i < arr.GetLength(0); i++)
{
    Write("[ ");
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(10, 99);
Write($"{arr[i, j] ,3}");
}
Write("] ");

WriteLine("");
}
    if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
WriteLine("Элемент не существует  ");
}
    else
{

   WriteLine($" Значение элемента массива = { arr[pos1, pos2]}");
   
}
WriteLine("");