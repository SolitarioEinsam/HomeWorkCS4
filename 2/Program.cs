int resultOfSum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

Console.Write("Введите число = ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(resultOfSum(num));