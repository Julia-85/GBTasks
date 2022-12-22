using static System.Console;

int number = new Random().Next(100,1000);

WriteLine(number);

int a = number/10;
int c = a%10;


WriteLine($"{c}");