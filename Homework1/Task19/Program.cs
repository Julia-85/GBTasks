using static System.Console;

WriteLine("Введите пятизначное число: ");
int n = int.Parse(ReadLine()!);

int a = n/10000;
int b = n/1000%10;
int c = n/10%10;
int d = n%10;

if ((a == d) & (b == c))
// if ((n/10000 == n%10) & (n/1000%10 == n/10%10))
{
     WriteLine("да");
}

else
{
     WriteLine("нет");
}

