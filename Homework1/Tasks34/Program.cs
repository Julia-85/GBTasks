// Напишите программу реализующую методы формирования массива, 
//заполненного случайными положительными трёхзначными числами,
// и подсчета количества чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using static System.Console;


WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(ReadLine()!);
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteLine("массив: ");
PrintArray(numbers);




int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
if (numbers[i] % 2 == 0)
count++;
}
WriteLine($"{count} чётные");



void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}



void PrintArray(int[] numbers)
{
  Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Write(numbers[i] + " ");
    }
   Write("]");
   WriteLine();
}