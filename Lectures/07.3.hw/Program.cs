// 21. Принимает на вход координаты двух точек и находит расстояние между ними в 3Д пространстве.

System.Console.Write("AX = ");
double AX = double.Parse(Console.ReadLine());

System.Console.Write("AY = ");
double AY = double.Parse(Console.ReadLine());

System.Console.Write("AZ = ");
double AZ = double.Parse(Console.ReadLine());

System.Console.Write("BX = ");
double BX = double.Parse(Console.ReadLine());

System.Console.Write("BY = ");
double BY = double.Parse(Console.ReadLine());

System.Console.Write("BZ = ");
double BZ = double.Parse(Console.ReadLine());


double Hypo = Math.Sqrt(Math.Pow((BX - AX),2) + Math.Pow((BY - AY),2));
System.Console.WriteLine($"Гипотенуза для промежуточных вычислений (through Math.Sqrt) = {Math.Round(Hypo,3)} cm");

double Distance = Math.Pow((Math.Pow(Hypo,2) + Math.Pow(BZ - AZ,2)),1/2f);
System.Console.WriteLine($"Distance between points (through Math.Pow(x, 1/2f)) = {Math.Round(Distance,3)} cm");

double DistanceSM = Math.Sqrt(Math.Pow((BX - AX),2) + Math.Pow((BY - AY),2) + Math.Pow((BZ - AZ),2));
System.Console.WriteLine($"Full formula from the seminar (through Math.Sqrt) = {Math.Round(DistanceSM,3)} cm");


// Принимает на вход пятизначное число и проверяет, является ли оно палиндромом

System.Console.Write("Enter the number: ");
int Nm = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Введенное число = {Nm}");
int mN = Nm % 10 * 10000 + Nm / 10 % 10 * 1000 + Nm / 100 % 10 * 100 + Nm / 1000 % 10 * 10 + Nm / 10000;
System.Console.WriteLine($"Обратная последовательность = {mN}");
if (Nm == mN)
{
    System.Console.WriteLine("Число является палиндромным");
}
else 
{
    System.Console.WriteLine("Число НЕ является палиндромным");
}