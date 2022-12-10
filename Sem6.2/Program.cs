/*
Задача 40: Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше
суммы двух других сторон
*/

// Ввод длин сторон по очереди
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
Console.ReadKey();


// Ввод длин сторон сразу через пробел
Console.Clear();
Console.Write("Введите длины сторон треугольника через пробел: ");
string A = Console.ReadLine()!;
string[] array = A.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
double[] arr = array.Select(double.Parse).ToArray();
if(arr[0]+arr[1] > arr[2]
    && arr[1]+arr[2] > arr[0]
    && arr[0]+arr[2] > arr[1]
    && arr[0] > 0
    && arr[1] > 0
    && arr[2] > 0)
    Console.WriteLine("Такой треугольник существует");
else 
    Console.WriteLine("Такого треугольник не существует");