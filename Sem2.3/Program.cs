/*
Напишите программу, которая будет принимать на вход два числа и выводит,
является ли второе число кратным первому. Если число 2 не кратно числу 1,
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a % b == 0) Console.WriteLine($"{a} кратно {b}");
else Console.WriteLine($"{a} не кратно {b}, остаток {a % b}");