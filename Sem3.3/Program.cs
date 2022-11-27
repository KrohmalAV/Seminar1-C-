/*
21)Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();
Console.Write("Введите координату X точка А: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точка А: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X точка B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точка B: ");
double yB = Convert.ToDouble(Console.ReadLine());
double xAxB = xA - xB;
double yAyB = yA - yB;
double L = Math.Pow((xAxB * xAxB + yAyB * yAyB), 0.5);
double l = Math.Round(L, 2);
Console.WriteLine(l);