// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine ("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool shouldRun = true;
Console.WriteLine("Чётные числа от 1 до " + count);
while (i <= count)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        shouldRun = false;
    }
    i++;
    }

if (shouldRun)
{
    Console.WriteLine("Нет чётных чисел!");
}
