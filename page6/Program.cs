//  Программа на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine ("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());
if (count%2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}