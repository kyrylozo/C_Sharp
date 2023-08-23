// Принимает на вход 2 числа и выводит, является ли 2-е число кратным 1-му. Если нет - выводит остаток деления

int A = new Random().Next(10, 100);
int B = new Random().Next(10, 100);
System.Console.WriteLine($"First number = {A}");
System.Console.WriteLine($"Second number = {B}");

if (B % A == 0)
{
    System.Console.WriteLine($"Второе число кранто 1-му");
}
else
{
    System.Console.WriteLine($"Остаток от деления 2 числа = {B % A}");
}