// Принимает на вход координаты точки (Х и У), причем Х не = 0 и У не = 0 
// и выдает номер четверьи плоскости, в которой находится эта точка
//
System.Console.Write("Введите координату Х = ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("Введите коордтнату У = ");
int y = int.Parse(Console.ReadLine());
System.Console.WriteLine(x);
System.Console.WriteLine(y);

if (0 < x && 0 < y)
{
    System.Console.WriteLine("1 section");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("2 section");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("3 section");
}
else
{
    System.Console.WriteLine("4 section");
}