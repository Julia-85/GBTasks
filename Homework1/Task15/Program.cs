using static System.Console;

WriteLine("Введите номер дня недели:");
int a = int.Parse(ReadLine()!);

if (a>0 & a<6)
{
    WriteLine("нет");
}
else if (a>5 & a<8)
{
    WriteLine("да");
}
else WriteLine("Неверное число");