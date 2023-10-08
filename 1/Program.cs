int degreeOf(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Write("Ведите число для возведения в степень = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число в какую степень возвести = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(degreeOf(a, b));