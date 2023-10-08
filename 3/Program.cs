void arrInitialization(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Введите чилсо для {i + 1} элемента массива = ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void arrWrite(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write(arr[i] + $" ");
    }
}
int[] arr = new int [8];
arrInitialization(arr);
arrWrite(arr);
