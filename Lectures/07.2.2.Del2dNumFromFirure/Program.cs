// Выводит случайное трехзначное число и удаляет 2-ю цифру этого числа

int Num = new Random().Next(100, 1000);
int a = Num / 100 * 10;
int b = Num % 10;
int R = a + b;
System.Console.WriteLine($"Rundom number = {Num}");
System.Console.WriteLine(R);
