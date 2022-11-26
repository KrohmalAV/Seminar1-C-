/*
Напишите программу, которая выводит случайное трехзначное число
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine(n);
int EndN = (n / 100) * 10 + n % 10;
Console.WriteLine(EndN);
