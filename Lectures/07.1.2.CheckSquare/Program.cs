// Принимаепт два числа и проверчяет, является ли первое квадратом второго

Console.WriteLine("Enter the 1st number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2d number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
int Square = Num2 * Num2;
if(Square == Num1)
{
    Console.WriteLine ($"{Num1} равно квадрату {Num2}");
}
else
{
    Console.WriteLine ($"Число {Num1} не является квадратом {Num2}");
}


