// Находит максимальное значение из 9 цифр, которые вводятся в массив


//.          0   1   2   3   4   5   6      7     8
int[] ar = {111, 21, 321, 421, 15, 61, 171, 183, 19};

Console.WriteLine(ar[0]);

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

int max = Max(
    Max(ar[0], ar[1], ar[2]),
    Max(ar[3], ar[4], ar[5]),
    Max(ar[6], ar[7], ar[8])
    );

System.Console.WriteLine($"Максимальное значение из 9 цифр: {max}");
