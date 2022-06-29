Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (N > 0)
{
    while (i < N + 1)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
}
else Console.Write("Число слишком мало");