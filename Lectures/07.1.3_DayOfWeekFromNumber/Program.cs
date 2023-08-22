// Выводит название дня недели по заданному номеру

Console.WriteLine("Enter the number from 1 to 7");
int DayNum = Convert.ToInt32(Console.ReadLine());
if (DayNum == 1) 
{
    Console.WriteLine("Monday");
}
else if (DayNum == 2) 
{
    Console.WriteLine("Tuesday");
}
else if (DayNum == 3)
{
    Console.WriteLine("Wednesday");
}
else if (DayNum == 4)
{
    Console.WriteLine("Thursday");
}
else if (DayNum == 5) 
{
    Console.WriteLine("Friday");
}
else if (DayNum == 6)
{
    Console.WriteLine("Saturday");
}
else if (DayNum == 7)
{
    Console.WriteLine("Sunday");
}
else //if (DayNum < 1 || DayNum > 7) 
{
    Console.WriteLine("Enter correct number");
}
