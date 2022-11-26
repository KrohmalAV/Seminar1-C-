/*
Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
double a2 = Math.Pow(a, 2);
if(a2  == b) Console.WriteLine($"{b} является квадратом {a}");
else Console.WriteLine($"{b} не является квадратом {a}");
