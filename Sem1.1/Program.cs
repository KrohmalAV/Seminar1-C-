﻿Console.Clear();
Console.Write("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b * b)
{
    Console.WriteLine($"{a} является квадратом {b}");
}
else
{
    Console.WriteLine($"{a} не является квадратом {b}");
}