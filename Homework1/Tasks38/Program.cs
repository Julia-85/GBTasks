// Напишите программу реализующую методы формирования массива, 
//заполненного случайными вещественными числами и 
//вычисления разницы между максимальным и минимальным элементов массива.
//[3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;

WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
WriteLine("массив: ");
PrintArray(numbers);






double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
WriteLine($"Разница между максимальным и минимальным элементом = {max - min}");





void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}



void PrintArray(double[] numbers)
{
    Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Write(numbers[i] + " ");
        }
    Write("]");
    WriteLine();
}