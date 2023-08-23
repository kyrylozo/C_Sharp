// Выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

int N = new Random().Next(10, 100);
int a = N / 10;
int b = N % 10;
System.Console.WriteLine(N);
System.Console.WriteLine(a);
System.Console.WriteLine(b);
if (a > b)
{
    System.Console.WriteLine($"{a} > {b}");
}

