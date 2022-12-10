/*
Задача 40: Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше
суммы двух других сторон
*/

Console.Clear();
Console.Write("Введите длинну первой стороны треугольника: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длинну второй стороны треугольника: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длинну третьей стороны треугольника: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
if(a+b > c && b+c > a && c+a > b && a > 0 && b > 0 && c > 0)
    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
else 
    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не существует");