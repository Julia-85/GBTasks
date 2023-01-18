// Напишите программу, реализующую метод,
// который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.

using static System.Console;

int []array= NewArray();
//PrintArray(array);





int [] NewArray()
{
   int [] arr =new int [8];
for (int i = 0; i < 8; i++)
{
   arr[i]=new Random().Next(1,99);
   Write($"{arr [i]},");
  // WriteLine(arr[i]);
}
return arr;
}
WriteLine();

//  void PrintArray(int[] arr)
//  {
//    int count = arr.Length;
//    for (int i = 0; i < count; i++)
//    {
//      Write($"{arr [i]} ");
//    }
//    WriteLine();
//  }