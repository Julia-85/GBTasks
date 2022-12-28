
using static System.Console;

Write("Точка a - Введите координату х: ");
int.TryParse(ReadLine(), out int ax);
Write("Точка a - Введите координату y: ");
int.TryParse(ReadLine(), out int ay);
Write("Точка a - Введите координату z: ");
int.TryParse(ReadLine(), out int az);
Write("Точка b - Введите координату x: ");
int.TryParse(ReadLine(), out int bx);
Write("Точка b - Введите координату y: ");
int.TryParse(ReadLine(), out int by);
Write("Точка b - Введите координату z: ");
int.TryParse(ReadLine(), out int bz);

double distance = Math.Sqrt(Math.Pow((ax-bx),2)+Math.Pow((ay-by),2)+Math.Pow((az-bz),2));
WriteLine($"{distance:f2}");