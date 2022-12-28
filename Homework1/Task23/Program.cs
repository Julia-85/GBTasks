using static System.Console;


WriteLine ("Введите число: ");
int.TryParse(ReadLine(), out int n);
int a = 1;

while(a < n+1)
{
    WriteLine($"Куб числа {a} = {Math.Pow(a,3)}");
    a++;
}