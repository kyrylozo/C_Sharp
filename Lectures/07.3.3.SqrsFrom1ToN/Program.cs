// Принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

System.Console.Write("Enter the number: ");
double N = double.Parse(Console.ReadLine());
while (N > 0)
{
    System.Console.WriteLine($"Квадрат числа {N} = {Math.Pow(N,2)}");
    N -= 1;
}
