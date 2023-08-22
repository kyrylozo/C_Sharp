// 4. На вход принимает 3 числа и выдает максимальное из этих чисел

System.Console.WriteLine("Ввести числа: ");
int N1 = Convert.ToInt32(Console.ReadLine());
int N2 = Convert.ToInt32(Console.ReadLine());
int N3 = Convert.ToInt32(Console.ReadLine());
int max = N1;
if (N2 > max)
{
    max = N2;
}
else if (N3 > max)
{
    max = N3;
}
System.Console.WriteLine($"Max value = {max}");

// 6. На вход принимает чило и выдает, является ли число четным (делится ли оно без отстка)

System.Console.WriteLine("Enter the number: ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num % 2 == 0)
{
    System.Console.WriteLine($"Число {Num} четное");
}
else
{
    System.Console.WriteLine($"Число {Num} нечетное");
}

// 7. На вход принимает число (N), а на выходе показывает все четные числа от 1 до N

System.Console.WriteLine("Enter your number: ");
int Nb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Четные числа от {Nb} до 1: ");
while (Nb > 0)
{
    if (Nb % 2 == 0)
    {
        System.Console.Write($"{Nb}, ");
    }
    Nb-=1;
}