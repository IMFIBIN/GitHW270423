// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine ("Введите первое число: ");
int count1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int count2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
int count3 = Convert.ToInt32(Console.ReadLine());

if (count1<count2)
{
    if (count2<count3)
    {
        Console.WriteLine("Наибольшее из введённых чисел -> " + count3);;
    }
    else
    {
        Console.WriteLine("Наибольшее из введённых чисел -> " + count2);
    }
}
else
{
    Console.WriteLine("Наибольшее из введённых чисел -> " + count1);
}