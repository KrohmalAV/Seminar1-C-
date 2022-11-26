/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
Например:
78 -> 8
12-> 2
85 -> 8
*/

Console.Clear();
int n = new Random().Next(10, 100);
Console.WriteLine(n);
int max = n % 10;
if(max < n / 10) max = n / 10;
Console.WriteLine(max);
