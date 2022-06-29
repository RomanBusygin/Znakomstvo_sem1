Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (number1 > number2)
{
    max = number1;
    min = number2;
    Console.Write("Первое число больше, чем второе");
}
else if (number1 < number2)
{
    max = number2;
    min = number1;
    Console.Write("Второе число больше, чем первое");
}
else Console.Write("Числа равны");