// Принимает на вход координаты 2х точек и находит расстояние между ними в 2Д пространстве

System.Console.Write("Point 1 X = ");
double X1 = double.Parse(Console.ReadLine());
System.Console.Write("Point 1 Y = ");
double Y1 = double.Parse(Console.ReadLine());
System.Console.Write("Point 2 X = ");
double X2 = double.Parse(Console.ReadLine());
System.Console.Write("Point 2 Y = ");
double Y2 = double.Parse(Console.ReadLine());

double Distance = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
double Dist = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));

System.Console.WriteLine(Math.Round(Distance,2));
System.Console.WriteLine(Math.Round(Dist,3));
System.Console.WriteLine();

System.Console.WriteLine($"Through Sqrt {Math.Sqrt(9)}");
System.Console.WriteLine($"Trough Pow {Math.Pow(9, 1/2f)}");
// Извлечение корня любой степени: Math.Pow(x, 1/3f)
