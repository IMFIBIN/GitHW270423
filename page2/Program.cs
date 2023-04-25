// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine ("Введите первое число: ");
int count1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int count2 = Convert.ToInt32(Console.ReadLine());
if (count1 > count2)
{
    Console.WriteLine("a = " + count1 + "; " + "b = " + count2 + " -> " + "max = " + count1);
}
else
{
    Console.WriteLine("a = " + count1 + "; " + "b = " + count2 + " -> " + "max = " + count2);
}