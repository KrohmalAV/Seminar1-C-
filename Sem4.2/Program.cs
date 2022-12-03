/*
Задача 26: Напишите программу, которая принимает на вход число
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
Console.Write("Введите число: ");
string A = Console.ReadLine();
int length = A.Length;
Console.WriteLine($"В числе {A} - {length} цифр");