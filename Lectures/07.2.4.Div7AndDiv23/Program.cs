// Принимает число и проверяет, кратно ли оно одновременно 7 и 2

System.Console.WriteLine("Enter the number: ");
int n = int.Parse(Console.ReadLine());
if (n % 7 == 0 && n % 2 == 0)
{
    System.Console.WriteLine($"Number {n} can be devided either 7 or 2");
}
else
{
    System.Console.WriteLine($"Number {n} can not be divided to 7 and 2");
}