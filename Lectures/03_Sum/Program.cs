
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9  (new Random().Next(min, max-1) ВСЕГДА ГЕРЕРИРУЕТ int!
int numberB = new Random().Next(1, 10);
Console.Write ("Первое число ");
Console.WriteLine(numberA);
Console.Write ("Второе число ");
Console.WriteLine(numberB);
Console.Write ("Сумма ");
Console.WriteLine(numberA + numberB);

