/*
22) Напишите программу, которая принимает на вход число (N) и
выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();
Console.Write("Введите целое натуральное число: ");
double N = Convert.ToDouble(Console.ReadLine());
if(N > 0 && (N*10) % 10 == 0)
{
    for(int i = 1; i <= N; i++) Console.Write($"{i*i} ");
}
else Console.Write($"Просили же ввести целое натуральное число");