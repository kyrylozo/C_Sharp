// Находит максимальное значение из 9 цифр при помощи метода

int 
a1 = 51,
b1 = 52994,
c1 = 391,
a2 = 121,
b2 = 21,
c2 = 339999,
a3 = 13999,
b3 = 23,
c3 = 3132;

int Max (int a, int b, int c)
{
    int result = a;
    if (result < b)
    {
        result = b;
    }
    else if (result < c)
    {
        result = c;
    }
    return result;
}
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)
    );

// System.Console.WriteLine(max1);
// System.Console.WriteLine(max2);
// System.Console.WriteLine(max3);
System.Console.WriteLine($"Максимальное значение из 9 цифр: {max}");